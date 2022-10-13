using Newtonsoft.Json;
using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestorantiApplication.Views
{
    public partial class Products : Form
    {
        private HttpClient _client;
        private readonly static string _baseUrl = ConfigurationManager.AppSettings["baseUrl"].ToString();
        private readonly static string _basePathImage = ConfigurationManager.AppSettings["basePathImage"].ToString();
        private static List<Category>? _categories;
        public Products()
        {
            InitializeComponent();
            TxtPriceALaCarte.Text = "R$ " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:#,##0.00}", 0);
            TxtPriceRodizio.Text = "R$ " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:#,##0.00}", 0);
        }
        
        private void TxtPriceALaCarte_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPress(sender, e);
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao carregar formatar o preço Á La Carte do TextBox KeyPress. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        private void TxtPriceRodizio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPress(sender, e);
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao carregar formatar o preço Rodízio do TextBox KeyPress. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Tratar se o valor que está sendo digitado é apenas númerico.
                if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    TextBox textBox = (TextBox)sender;
                    string text = Regex.Replace(textBox.Text, "[^0-9]", string.Empty);
                    if (string.IsNullOrEmpty(text))
                        text = "00";

                    if (e.KeyChar.Equals((char)Keys.Back))
                        text = text.Substring(0, text.Length - 1);
                    else
                        text += e.KeyChar;

                    textBox.Text = "R$ " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:#,##0.00}", Double.Parse(text) / 100);
                    textBox.Select(textBox.Text.Length, 0);
                }

                e.Handled = true;
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao carregar formatar o preço TextBox KeyPress. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {

            //SetAll Enable = false;
            TxtProdName.Enabled = false;
            TxtPriceALaCarte.Enabled = false;
            TxtPriceRodizio.Enabled = false;
            TxtDescriptionProd.Enabled = false;
            ChkCategory.Enabled = false;
            ChkProductStatus.Enabled = false;

            //VisibleAll = True
            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }

            //Reset Combobox's
            ChkProductStatus.Items.Clear();
            ChkCategory.Items.Clear();

            #region GET ALL - Trazer todas as categorias cadastradas

            _client = new HttpClient();
            HttpResponseMessage result = _client.GetAsync($"{_baseUrl}/Category").Result;

            var categorys = JsonConvert.DeserializeObject<List<Category>>(result.Content.ReadAsStringAsync().Result);
            List<string> categories = new List<string>();

            categorys.ForEach(x =>
             categories.Add(x.Name)
            );

            #endregion

            if (categories?.Count() > 0)
            {
                //Adicionar a uma classe estática para fazer o de para futuramente.
                _categories = categorys;

                //Set list value enum combobox's
                ChkProductStatus.Items.AddRange(Enum.GetNames(typeof(EProductStatus)));
                ChkCategory.Items.AddRange(categories.ToArray());
            }
            else
            {
                //Garantindo que não terá objetos no de para de categorias.
                _categories = null;

                //Set list value enum combobox's
                ChkProductStatus.Items.AddRange(Enum.GetNames(typeof(EProductStatus)));
                ChkCategory.Items.Add("");
            }

            //Set value default combobox's
            ChkProductStatus.SelectedIndex = 0;
            ChkCategory.SelectedIndex = 0;

            //Set value default txtBox/Label and PictureBox
            TxtProdName.Text = String.Empty;
            TxtPriceALaCarte.Text = String.Empty;
            TxtPriceRodizio.Text = String.Empty;
            TxtDescriptionProd.Text = String.Empty;
            LblIdProduct.Text = 0.ToString();
            PbProduct.Image = null;

            #region GET All - Trazer todos os produtos cadastros para listar

            _client = new HttpClient();
            result = _client.GetAsync($"{_baseUrl}/Product").Result;

            var products = JsonConvert.DeserializeObject<List<Product>>(result.Content.ReadAsStringAsync().Result);

            if (products?.Count > 0)
            {
                //Clear list before add new itens.
                ListProducts.Items.Clear();
                foreach (var i in products)
                {
                    //Passar como parâmetro o ID da categoria
                    string[] rows = { i.ProductId.ToString(), i.Name, _categories.FirstOrDefault(x => x.Id == i.CategoryId).Name, i.Status.ToString(), i.PriceALaCarte.ToString(), i.PriceRodizio.ToString(), i.Description, i.ImageContent != null ? Encoding.ASCII.GetString(i.ImageContent) : null };

                    ListProducts.Items.Add(new ListViewItem(rows));
                }
            }

            #endregion

            //VisibleAll = True
            foreach (Control c in this.Controls)
            {
                c.Visible = true;
            }

            BtnUploadImageProd.Visible = false;
            BtnSaveImageProd.Visible = false;
            PanelImageBorder.Visible = false;
            LblImagemProd.Visible = false;

        }

        /// <summary>
        /// Pesquisar Produtos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchProduct_Click(object sender, EventArgs e)
        {
            try
            {
                BtnEditProduct.Text = "Editar";
                if (_categories?.Count > 0)
                {
                    //Caso o campo nome esteja desabilitado provavelmente todos vão estar. Habilitar
                    if (!TxtProdName.Enabled)
                    {
                        ActionsGenerics.ShowMessage("Habilitando todos os campos de pesquisa!");
                        TxtProdName.Enabled = true;
                        TxtPriceALaCarte.Enabled = false;
                        TxtPriceALaCarte.Text = String.Empty;
                        TxtPriceRodizio.Enabled = false;
                        TxtPriceRodizio.Text = String.Empty;
                        TxtDescriptionProd.Enabled = false;
                        TxtDescriptionProd.Text = String.Empty;
                        ChkCategory.Enabled = true;
                        ChkProductStatus.Enabled = true;
                        BtnUploadImageProd.Enabled = true;
                    }
                    else
                    {
                        PanelImageBorder.Visible = false;
                        BtnUploadImageProd.Visible = false;
                        BtnSaveImageProd.Visible = false;
                        BtnAddProduct.Text = "Novo";

                        if (
                            string.IsNullOrEmpty(TxtProdName.Text) &&
                            string.IsNullOrEmpty(ChkCategory.SelectedItem.ToString()) &&
                            string.IsNullOrEmpty(ChkProductStatus.SelectedItem.ToString())
                            )
                            Products_Load(sender, e);

                        _client = new HttpClient();
                        HttpResponseMessage result;

                        //Pegando o Id da categoria a partir do item selecionado.
                        int categoryId = _categories[ChkCategory.SelectedIndex].Id;

                        //Validar se o index selecionado bate com o ID e nome da categoria;
                        if (_categories[ChkCategory.SelectedIndex].Name == ChkCategory.GetItemText(ChkCategory.SelectedItem))
                        {

                            if (string.IsNullOrEmpty(TxtProdName.Text))
                                result = _client.GetAsync($"{_baseUrl}/Product/ListWithFilter?CategoryId={categoryId}&Status={ChkProductStatus.SelectedIndex}").Result;
                            else
                                result = _client.GetAsync($"{_baseUrl}/Product/ListWithFilter?CategoryId={categoryId}&Status={ChkProductStatus.SelectedIndex}&Name={TxtProdName.Text}").Result;

                            var response = JsonConvert.DeserializeObject<MessageResponse<List<Product>>>(result.Content.ReadAsStringAsync().Result);

                            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                var products = response.Entity;

                                if (products?.Count > 0)
                                {
                                    //Clear list before add new itens.
                                    ListProducts.Items.Clear();
                                    foreach (var i in products)
                                    {
                                        //Passar como parâmetro o ID da categoria
                                        string[] rows = { i.CategoryId.ToString(), i.Name, _categories.FirstOrDefault(x => x.Id == i.CategoryId).Name, i.Status.ToString(), i.PriceALaCarte.ToString(), i.PriceRodizio.ToString(), i.Description, i.ImageContent != null ? Encoding.ASCII.GetString(i.ImageContent) : null };
                                        ListProducts.Items.Add(new ListViewItem(rows));
                                    }
                                }
                                else
                                {
                                    ActionsGenerics.ShowMessage("Nenhuma categoria encontrada de acordo com os filtros!");
                                    Products_Load(sender, e);
                                }
                            }
                        }
                        else
                        {
                            ActionsGenerics.ShowMessage("Selecione uma categoria");
                        }
                    }
                }
                else
                {
                    ActionsGenerics.ShowMessage("Nenhuma produto foi encontrado. Tente novamente!");
                    Products_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao pesquisar uma categoria.Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Editar Produtos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnEditProduct.Text.Equals("Editar"))
                {
                    var listOfAllSelected = ListProducts.SelectedItems.Cast<ListViewItem>().ToList();
                    if (listOfAllSelected?.Count > 0)
                    {
                        foreach (var i in listOfAllSelected)
                        {
                            //Id do Produto
                            LblIdProduct.Text = i.Text;

                            //Nome do Produto
                            TxtProdName.Text = i.SubItems[1].Text;
                            TxtProdName.Enabled = true;

                            //Tipo de Categoria
                            ChkCategory.SelectedIndex = ChkCategory.Items.IndexOf(i.SubItems[2].Text);
                            ChkCategory.Enabled = true;

                            //Status do Produto
                            ChkProductStatus.SelectedIndex = (int)(EProductStatus)Enum.Parse(typeof(EProductStatus), i.SubItems[3].Text, true);
                            ChkProductStatus.Enabled = true;

                            //Preço do À La Carte
                            TxtPriceALaCarte.Text = $"R$ {i.SubItems[4].Text}";
                            TxtPriceALaCarte.Enabled = true;

                            //Preço do Rodízio
                            TxtPriceRodizio.Text = $"R$ {i.SubItems[5].Text}";
                            TxtPriceRodizio.Enabled = true;

                            //Descrição do Produto
                            TxtDescriptionProd.Text = i.SubItems[6].Text;
                            TxtDescriptionProd.Enabled = true;
                        }

                        BtnUploadImageProd.Visible = true;
                        BtnUploadImageProd.Enabled = true;

                        BtnEditProduct.Text = "Salvar";
                    }
                    else
                    {
                        ActionsGenerics.ShowMessage("Selecione um produto para conseguir editar!");
                    }
                }
                else if (BtnEditProduct.Text.Equals("Salvar"))
                {
                    _client = new HttpClient();
                    byte[] imageContent = null;

                    //Validar se fez o upload de uma imagem
                    if (PbProduct.Image != null)
                    {
                        imageContent = ImageForBytesArray(PbProduct.Image);
                    }

                    decimal PriceALaCarte = ConverToDecimal(TxtPriceALaCarte.Text);
                    decimal PriceRodizio = ConverToDecimal(TxtPriceRodizio.Text);

                    var product = new Product
                    {
                        ProductId = Convert.ToInt32(LblIdProduct.Text),
                        CategoryId = _categories[ChkCategory.SelectedIndex].Id,
                        Name = TxtProdName.Text,
                        Description = TxtDescriptionProd.Text,
                        PriceALaCarte = PriceALaCarte,
                        PriceRodizio = PriceRodizio,
                        Status = (EProductStatus)Enum.Parse(typeof(EProductStatus), ChkProductStatus.SelectedIndex.ToString(), true),
                        ImageContent = imageContent,
                        CreationDate = DateTime.Now,
                        CreationUserId = UserLogged.UserId
                    };

                    var request = JsonConvert.SerializeObject(product);
                    var contentString = new StringContent(request, Encoding.UTF8, "application/json");
                    contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage result = _client.PostAsync($"{_baseUrl}/Product/Update", contentString).Result;
                    var response = JsonConvert.DeserializeObject<MessageResponse<Product>>(result.Content.ReadAsStringAsync().Result);
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ActionsGenerics.ShowMessage(response.Message);
                        BtnEditProduct.Text = "Editar";
                        Products_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao tentar atualizar/salvar dados de uma categoria. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Criação de Produtos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnAddProduct.Text == "Novo")
                {
                    //Carregar a lista.
                    Products_Load(sender, e);

                    BtnEditProduct.Text = "Editar";
                    TxtProdName.Text = string.Empty;
                    TxtProdName.Enabled = true;
                    TxtDescriptionProd.Enabled = true;
                    TxtPriceALaCarte.Enabled = true;
                    TxtPriceRodizio.Enabled = true;
                    ChkCategory.Text = string.Empty;
                    ChkCategory.Enabled = true;
                    ChkProductStatus.Text = string.Empty;
                    ChkProductStatus.Enabled = true;
                    PbProduct.Image = null;
                    BtnAddProduct.Text = "Adicionar";
                    BtnUploadImageProd.Visible = true;
                    BtnUploadImageProd.Enabled = true;
                    PanelImageBorder.Visible = true;
                    LblImagemProd.Visible = true;
                }
                else
                {
                    if (!String.IsNullOrEmpty(TxtProdName.Text) && !String.IsNullOrEmpty(ChkCategory.Text) && !String.IsNullOrEmpty(ChkProductStatus.Text))
                    {
                        if (ActionsGenerics.ConfirmCustom("Você deseja adicionar o registro?"))
                        {
                            //Processo de adicionar no banco.
                            _client = new HttpClient();
                            byte[] imageContent = null;

                            //Validar se fez o upload de uma imagem
                            if (PbProduct.Image != null)
                            {
                                imageContent = ImageForBytesArray(PbProduct.Image);
                            }

                            decimal PriceALaCarte = ConverToDecimal(TxtPriceALaCarte.Text);
                            decimal PriceRodizio = ConverToDecimal(TxtPriceRodizio.Text);

                            var product = new Product
                            {
                                CategoryId = _categories[ChkCategory.SelectedIndex].Id,
                                Name = TxtProdName.Text,
                                Description = TxtDescriptionProd.Text,
                                PriceALaCarte = PriceALaCarte,
                                PriceRodizio = PriceRodizio,
                                Status = (EProductStatus)Enum.Parse(typeof(EProductStatus), ChkProductStatus.SelectedIndex.ToString(), true),
                                ImageContent = imageContent,
                                CreationDate = DateTime.Now,
                                CreationUserId = UserLogged.UserId
                            };

                            var request = JsonConvert.SerializeObject(product);
                            var contentString = new StringContent(request, Encoding.UTF8, "application/json");
                            contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                            HttpResponseMessage result = _client.PostAsync($"{_baseUrl}/Product", contentString).Result;
                            var response = JsonConvert.DeserializeObject<MessageResponse<Product>>(result.Content.ReadAsStringAsync().Result);
                            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                //Após salvar o registro zerar todos os campos e atualizar a lista
                                BtnEditProduct.Text = "Editar";
                                TxtProdName.Text = string.Empty;
                                ChkCategory.Text = string.Empty;
                                ChkProductStatus.Text = string.Empty;
                                PbProduct.Image = null;
                                BtnAddProduct.Text = "Novo";

                                //Carregar a lista.
                                Products_Load(sender, e);
                                ActionsGenerics.ShowMessage(response.Message);
                            }
                            else
                                ActionsGenerics.ShowMessage(response.Message);
                        }
                    }
                    else
                    {
                        ActionsGenerics.ShowMessage("Preencha todos os campos!");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao adicionar um novo produto.Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Remoção de Produtos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                BtnEditProduct.Text = "Editar";

                var listOfAllSelected = ListProducts.SelectedItems.Cast<ListViewItem>().ToList();
                if (listOfAllSelected?.Count > 0)
                {
                    if (ActionsGenerics.ConfirmCustom("Tem certeza que deseja excluir o produto?"))
                    {

                        foreach (var i in listOfAllSelected)
                        {
                            //Id do produto
                            LblIdProduct.Text = i.Text;
                        }

                        _client = new HttpClient();
                        HttpResponseMessage result = _client.DeleteAsync($"{_baseUrl}/Product/Delete/{Convert.ToInt32(LblIdProduct.Text)}").Result;
                        var response = JsonConvert.DeserializeObject<MessageResponse<Product>>(result.Content.ReadAsStringAsync().Result);
                        if (result.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            ActionsGenerics.ShowMessage(response.Message);
                            Products_Load(sender, e);
                        }
                        else
                            ActionsGenerics.ShowMessage(response.Message);
                    }
                }
                else
                {
                    ActionsGenerics.ShowMessage("Selecione uma categoria para conseguir remover!");
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao remover uma categoria.Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Método para converter a imaem em bytes[]
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private byte[] ImageForBytesArray(Image image)
        {
            try
            {
                using (var myBitmap = new Bitmap(image))
                {
                    MemoryStream ms = new MemoryStream();
                    myBitmap.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao tentar converter a imagem de produto em bytes.Exception: {ex.Message} StackTrace: {ex.StackTrace}");
                return null;
            }
        }

        public decimal ConverToDecimal(string Value)
        {
            decimal newValue = 0;
            //valida se é valor em dinheiro
            if (Value.Contains("R$"))
            {
                Value = Value.Substring(3, Value.Length - 3);
                newValue = Convert.ToDecimal(Value);
            }
            return newValue;
        }

        private void ListProducts_Click(object sender, EventArgs e)
        {
            try
            {
                PanelImageBorder.Visible = false;
                BtnEditProduct.Text = "Editar";
                TxtProdName.Text = String.Empty;
                ChkCategory.Text = String.Empty;
                ChkProductStatus.Text = String.Empty;
                PbProduct.Image = null;
                BtnSaveImageProd.Visible = false;
                BtnUploadImageProd.Visible = false;
                BtnAddProduct.Text = "Novo";

                foreach (var i in ListProducts.SelectedItems.Cast<ListViewItem>().ToList())
                {
                    ChkCategory.SelectedIndex = -1;
                    ChkProductStatus.SelectedIndex = -1;

                    _client = new HttpClient();
                    HttpResponseMessage result = _client.GetAsync($"{_baseUrl}/Product/GetImage/{Convert.ToInt32(i.Text)}").Result;

                    //Id do Produto
                    LblIdProduct.Text = i.Text;

                    //Nome do Produto
                    TxtProdName.Text = i.SubItems[1].Text;
                    TxtProdName.Enabled = false;

                    //Tipo de Categoria
                    ChkCategory.SelectedIndex = ChkCategory.Items.IndexOf(i.SubItems[2].Text);
                    ChkCategory.Enabled = false;

                    //Status do Produto
                    ChkProductStatus.SelectedIndex = (int)(EProductStatus)Enum.Parse(typeof(EProductStatus), i.SubItems[3].Text, true);
                    ChkProductStatus.Enabled = false;

                    //Preço do À La Carte
                    TxtPriceALaCarte.Text = $"R$ {i.SubItems[4].Text}";
                    TxtPriceALaCarte.Enabled = false;

                    //Preço do Rodízio
                    TxtPriceRodizio.Text = $"R$ {i.SubItems[5].Text}";
                    TxtPriceRodizio.Enabled = false;

                    //Descrição do Produto
                    TxtDescriptionProd.Text = i.SubItems[6].Text;
                    TxtDescriptionProd.Enabled = false;


                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var category = JsonConvert.DeserializeObject<Category>(result.Content.ReadAsStringAsync().Result);

                        if (category.ImageContent != null)
                        {
                            using (var memoryStream = new MemoryStream(category.ImageContent))
                            {
                                PbProduct.Image = Image.FromStream(memoryStream, true);
                                BtnUploadImageProd.Enabled = false;
                            }
                        }
                    }

                    if (PbProduct.Image != null)
                    {
                        LblImagemProd.Visible = true;
                        BtnSaveImageProd.Visible = true;
                        PanelImageBorder.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao atualizar formulário de produtos ao selecionar um da lista. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        private void BtnUploadImageProd_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    byte[] imgBytes;
                    Bitmap bmp = new Bitmap(openFileDialog.FileName);
                    Image image = bmp;

                    using (var memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, image.RawFormat);
                        imgBytes = memoryStream.ToArray();
                        PbProduct.Image = Image.FromStream(memoryStream);
                    }

                    PanelImageBorder.Visible = true;
                    BtnSaveImageProd.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao realizar o upload de uma imagem de produto .Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        private void BtnSaveImageProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActionsGenerics.ConfirmCustom("Deseja realizar o download da imagem?"))
                {
                    MemoryStream ms = new MemoryStream();
                    using (var myBitmap = new Bitmap(PbProduct.Image))
                    {
                        myBitmap.Save(ms, ImageFormat.Jpeg);
                    }

                    if (File.Exists(_basePathImage + TxtProdName.Text.Replace(" ","") + ".jpg"))
                    {
                        var folderName = _basePathImage.Replace(@"\\", "/");
                        folderName = folderName.Substring(0, folderName.Length - 1);
                        if (ActionsGenerics.ConfirmCustom($"Existe uma imagem com o nome {TxtProdName.Text.Replace(" ", "")} salvo em {folderName}. Você deseja substituir?"))
                            File.WriteAllBytes(@$"C:\\Restoranti\\Imagens\\{TxtProdName.Text.Replace(" ", "")}.jpg", ms.ToArray());
                    }
                    else
                        File.WriteAllBytes(@$"C:\\Restoranti\\Imagens\\{TxtProdName.Text.Replace(" ", "")}.jpg", ms.ToArray());
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao realizar o download da imagem de produto {TxtProdName.Text}.Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }
    }
}
