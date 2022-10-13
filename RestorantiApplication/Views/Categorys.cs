using Newtonsoft.Json;
using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Drawing.Imaging;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;

namespace RestorantiApplication.Views
{
    public partial class Categorys : Form
    {
        private HttpClient _client;
        private readonly static string _baseUrl = ConfigurationManager.AppSettings["baseUrl"].ToString();
        private readonly static string _basePathImage = ConfigurationManager.AppSettings["basePathImage"].ToString();
        public Categorys()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ao carregar o formulário de categorias.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Categorys_Load(object sender, EventArgs e)
        {
            try
            {
                //SetAll Enable = false;
                TxtCatName.Enabled = false;
                ChkMenuType.Enabled = false;
                ChkStatus.Enabled = false;

                //VisibleAll = True
                foreach (Control c in this.Controls)
                {
                    c.Visible = false;
                }

                //Reset Combobox's
                ChkStatus.Items.Clear();
                ChkMenuType.Items.Clear();

                //Set list value enum combobox's
                ChkMenuType.Items.AddRange(Enum.GetNames(typeof(EMenuType)));
                ChkStatus.Items.AddRange(Enum.GetNames(typeof(ECategoryStatus)));

                //Set value default combobox's
                ChkMenuType.SelectedIndex = 0;
                ChkStatus.SelectedIndex = 0;

                //Set value default txtBox/Label and PictureBox
                TxtCatName.Text = String.Empty;
                lblIdCategory.Text = 0.ToString();
                PbCategory.Image = null;

                _client = new HttpClient();
                HttpResponseMessage result = _client.GetAsync($"{_baseUrl}/Category").Result;

                var categorys = JsonConvert.DeserializeObject<List<Category>>(result.Content.ReadAsStringAsync().Result);

                if (categorys?.Count > 0)
                {
                    //Clear list before add new itens.
                    ListCategorys.Items.Clear();
                    foreach (var i in categorys)
                    {
                        //Passar como parâmetro o ID da categoria
                        string[] rows = { i.Id.ToString(), i.Name, i.MenuType.ToString(), i.Status.ToString(), i.ImageContent != null ? Encoding.ASCII.GetString(i.ImageContent) : null };

                        ListCategorys.Items.Add(new ListViewItem(rows));
                    }
                }

                //VisibleAll = True
                foreach (Control c in this.Controls)
                {
                    c.Visible = true;
                }

                BtnUploadImageCat.Visible = false;
                BtnSaveImage.Visible = false;
                PanelImageBorder.Visible = false;
                LblImagem.Visible = false;
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao carregar a página geral de categorias. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Botão de Editar/Salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnUpdate.Text.Equals("Editar"))
                {
                    var listOfAllSelected = ListCategorys.SelectedItems.Cast<ListViewItem>().ToList();
                    if (listOfAllSelected?.Count > 0)
                    {
                        foreach (var i in listOfAllSelected)
                        {
                            //Id da categoria
                            lblIdCategory.Text = i.Text;

                            //Nome da categoria
                            TxtCatName.Text = i.SubItems[1].Text;

                            //Tipo do cardápio
                            ChkMenuType.SelectedIndex = (int)(EMenuType)Enum.Parse(typeof(EMenuType), i.SubItems[2].Text, true);

                            //Status da categoria
                            ChkStatus.SelectedIndex = (int)(ECategoryStatus)Enum.Parse(typeof(ECategoryStatus), i.SubItems[3].Text, true);
                        }

                        TxtCatName.Enabled = true;
                        ChkMenuType.Enabled = true;
                        ChkStatus.Enabled = true;
                        BtnUploadImageCat.Visible = true;
                        BtnUploadImageCat.Enabled = true;

                        BtnUpdate.Text = "Salvar";
                    }
                    else
                    {
                        ActionsGenerics.ShowMessage("Selecione uma categoria para conseguir editar!");
                    }
                }
                else if (BtnUpdate.Text.Equals("Salvar"))
                {
                    _client = new HttpClient();
                    byte[] imageContent = null;

                    //Validar se fez o upload de uma imagem
                    if (PbCategory.Image != null)
                    {
                        imageContent = ImageForBytesArray(PbCategory.Image);
                    }

                    var category = new Category
                    {
                        Id = Convert.ToInt32(lblIdCategory.Text),
                        Name = TxtCatName.Text,
                        ImageContent = imageContent,
                        MenuType = (EMenuType)Enum.Parse(typeof(EMenuType), ChkMenuType.SelectedIndex.ToString(), true),
                        Status = (ECategoryStatus)Enum.Parse(typeof(ECategoryStatus), ChkStatus.SelectedIndex.ToString(), true),
                        ModifiedDate = DateTime.Now,
                        ModifiedUserId = UserLogged.UserId
                    };

                    var request = JsonConvert.SerializeObject(category);
                    var contentString = new StringContent(request, Encoding.UTF8, "application/json");
                    contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage result = _client.PostAsync($"{_baseUrl}/Category/Update", contentString).Result;
                    var response = JsonConvert.DeserializeObject<MessageResponse<Category>>(result.Content.ReadAsStringAsync().Result);
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ActionsGenerics.ShowMessage(response.Message);
                        BtnUpdate.Text = "Editar";
                        Categorys_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao tentar atualizar/salvar dados de uma categoria. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }

        }

        /// <summary>
        /// Quando clicar sobre o ID de qualquer registro da tabela, preencher todos os campos do formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCategorys_Click(object sender, EventArgs e)
        {
            try
            {
                PanelImageBorder.Visible = false;
                BtnUpdate.Text = "Editar";
                TxtCatName.Text = String.Empty;
                ChkMenuType.Text = String.Empty;
                ChkStatus.Text = String.Empty;
                PbCategory.Image = null;
                BtnSaveImage.Visible = false;
                BtnUploadImageCat.Visible = false;
                BtnAdd.Text = "Novo";

                foreach (var i in ListCategorys.SelectedItems.Cast<ListViewItem>().ToList())
                {
                    ChkMenuType.SelectedIndex = -1;
                    ChkStatus.SelectedIndex = -1;

                    _client = new HttpClient();
                    HttpResponseMessage result = _client.GetAsync($"{_baseUrl}/Category/GetImage/{Convert.ToInt32(i.Text)}").Result;

                    //Id da categoria
                    lblIdCategory.Text = i.Text;

                    //Nome da categoria
                    TxtCatName.Text = i.SubItems[1].Text;
                    TxtCatName.Enabled = false;

                    //Tipo do cardápio
                    ChkMenuType.SelectedIndex = (int)(EMenuType)Enum.Parse(typeof(EMenuType), i.SubItems[2].Text, true);
                    ChkMenuType.Enabled = false;

                    //Status da categoria
                    ChkStatus.SelectedIndex = (int)(ECategoryStatus)Enum.Parse(typeof(ECategoryStatus), i.SubItems[3].Text, true);
                    ChkStatus.Enabled = false;


                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var category = JsonConvert.DeserializeObject<Category>(result.Content.ReadAsStringAsync().Result);

                        if (category.ImageContent != null)
                        {
                            using (var memoryStream = new MemoryStream(category.ImageContent))
                            {
                                PbCategory.Image = Image.FromStream(memoryStream, true);
                                BtnUploadImageCat.Enabled = false;
                            }
                        }
                    }

                    if (PbCategory.Image != null)
                    {
                        LblImagem.Visible = true;
                        BtnSaveImage.Visible = true;
                        PanelImageBorder.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao atualizar formulário de categoria ao selecionar um da lista. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Botão de Adicionar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnAdd.Text == "Novo")
                {
                    //Carregar a lista.
                    Categorys_Load(sender, e);

                    BtnUpdate.Text = "Editar";
                    TxtCatName.Text = string.Empty;
                    TxtCatName.Enabled = true;
                    ChkMenuType.Text = string.Empty;
                    ChkMenuType.Enabled = true;
                    ChkStatus.Text = string.Empty;
                    ChkStatus.Enabled = true;
                    PbCategory.Image = null;
                    BtnAdd.Text = "Adicionar";
                    BtnUploadImageCat.Visible = true;
                    BtnUploadImageCat.Enabled = true;
                    PanelImageBorder.Visible = true;
                    LblImagem.Visible = true;
                }
                else
                {
                    if (!String.IsNullOrEmpty(TxtCatName.Text) && !String.IsNullOrEmpty(ChkMenuType.Text) && !String.IsNullOrEmpty(ChkStatus.Text))
                    {
                        if (ActionsGenerics.ConfirmCustom("Você deseja adicionar o registro?"))
                        {
                            //Processo de adicionar no banco.
                            _client = new HttpClient();
                            byte[] imageContent = null;

                            //Validar se fez o upload de uma imagem
                            if (PbCategory.Image != null)
                            {
                                imageContent = ImageForBytesArray(PbCategory.Image);
                            }

                            var category = new Category
                            {
                                Name = TxtCatName.Text,
                                ImageContent = imageContent,
                                MenuType = (EMenuType)Enum.Parse(typeof(EMenuType), ChkMenuType.SelectedIndex.ToString(), true),
                                Status = (ECategoryStatus)Enum.Parse(typeof(ECategoryStatus), ChkStatus.SelectedIndex.ToString(), true),
                                CreationDate = DateTime.Now,
                                CreationUserId = UserLogged.UserId
                            };

                            var request = JsonConvert.SerializeObject(category);
                            var contentString = new StringContent(request, Encoding.UTF8, "application/json");
                            contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                            HttpResponseMessage result = _client.PostAsync($"{_baseUrl}/Category", contentString).Result;
                            var response = JsonConvert.DeserializeObject<MessageResponse<Category>>(result.Content.ReadAsStringAsync().Result);
                            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                //Após salvar o registro zerar todos os campos e atualizar a lista
                                BtnUpdate.Text = "Editar";
                                TxtCatName.Text = string.Empty;
                                ChkMenuType.Text = string.Empty;
                                ChkStatus.Text = string.Empty;
                                PbCategory.Image = null;
                                BtnAdd.Text = "Novo";

                                //Carregar a lista.
                                Categorys_Load(sender, e);
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
                Logger.Write($"Erro ao adicionar uma nova categoria.Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Botão de Remover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                BtnUpdate.Text = "Editar";

                var listOfAllSelected = ListCategorys.SelectedItems.Cast<ListViewItem>().ToList();
                if (listOfAllSelected?.Count > 0)
                {
                    if (ActionsGenerics.ConfirmCustom("Tem certeza que deseja excluir a categoria?"))
                    {

                        foreach (var i in listOfAllSelected)
                        {
                            //Id da categoria
                            lblIdCategory.Text = i.Text;
                        }

                        _client = new HttpClient();
                        HttpResponseMessage result = _client.DeleteAsync($"{_baseUrl}/Category/Delete/{Convert.ToInt32(lblIdCategory.Text)}").Result;
                        var response = JsonConvert.DeserializeObject<MessageResponse<Category>>(result.Content.ReadAsStringAsync().Result);
                        if (result.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            ActionsGenerics.ShowMessage(response.Message);
                            Categorys_Load(sender, e);

                            TxtCatName.Enabled = true;
                            ChkMenuType.Enabled = true;
                            ChkStatus.Enabled = true;
                            BtnUploadImageCat.Enabled = true;
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
        /// Botão de Pesquisar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                BtnUpdate.Text = "Editar";

                //Caso o campo nome esteja desabilitado provavelmente todos vão estar. Habilitar
                if (!TxtCatName.Enabled)
                {
                    ActionsGenerics.ShowMessage("Habilitando todos os campos de pesquisa!");
                    TxtCatName.Enabled = true;
                    ChkMenuType.Enabled = true;
                    ChkStatus.Enabled = true;
                    BtnUploadImageCat.Enabled = true;
                }
                else
                {
                    PanelImageBorder.Visible = false;
                    BtnUploadImageCat.Visible = false;
                    BtnSaveImage.Visible = false;
                    BtnAdd.Text = "Novo";
                    if (
                        string.IsNullOrEmpty(TxtCatName.Text) &&
                        string.IsNullOrEmpty(ChkMenuType.SelectedItem.ToString()) &&
                        string.IsNullOrEmpty(ChkStatus.SelectedItem.ToString())
                        )
                        Categorys_Load(sender, e);

                    _client = new HttpClient();
                    HttpResponseMessage result;

                    if (string.IsNullOrEmpty(TxtCatName.Text))
                        result = _client.GetAsync($"{_baseUrl}/Category/ListWithFilter?MenuType={ChkMenuType.SelectedIndex}&Status={ChkStatus.SelectedIndex}").Result;
                    else
                        result = _client.GetAsync($"{_baseUrl}/Category/ListWithFilter?MenuType={ChkMenuType.SelectedIndex}&Status={ChkStatus.SelectedIndex}&Name={TxtCatName.Text}").Result;

                    var response = JsonConvert.DeserializeObject<MessageResponse<List<Category>>>(result.Content.ReadAsStringAsync().Result);

                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var categorys = response.Entity;

                        if (categorys?.Count > 0)
                        {
                            //Clear list before add new itens.
                            ListCategorys.Items.Clear();
                            foreach (var i in categorys)
                            {
                                //Passar como parâmetro o ID da categoria
                                string[] rows = { i.Id.ToString(), i.Name, i.MenuType.ToString(), i.Status.ToString(), i.ImageContent != null ? Encoding.ASCII.GetString(i.ImageContent) : null };
                                ListCategorys.Items.Add(new ListViewItem(rows));
                            }
                        }
                        else
                        {
                            ActionsGenerics.ShowMessage("Nenhuma categoria encontrada de acordo com os filtros!");
                            Categorys_Load(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao pesquisar uma categoria.Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Botão para upload da imagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUploadImageCat_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    byte[] imgBytes;
                    Bitmap bmp = new Bitmap(openFileDialog.FileName);
                    System.Drawing.Image image = bmp;

                    using (var memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, image.RawFormat);
                        imgBytes = memoryStream.ToArray();
                        PbCategory.Image = Image.FromStream(memoryStream);
                    }

                    PanelImageBorder.Visible = true;
                    BtnSaveImage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao realizar o upload de uma imagem de categoria .Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Botão para fazer o download de imagens de categorias.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActionsGenerics.ConfirmCustom("Deseja realizar o download da imagem?"))
                {
                    MemoryStream ms = new MemoryStream();
                    using (var myBitmap = new Bitmap(PbCategory.Image))
                    {
                        myBitmap.Save(ms, ImageFormat.Jpeg);
                    }

                    if (File.Exists(_basePathImage + TxtCatName.Text + ".jpg"))
                    {
                        var folderName = _basePathImage.Replace(@"\\", "/");
                        folderName = folderName.Substring(0, folderName.Length - 1);
                        if (ActionsGenerics.ConfirmCustom($"Existe uma imagem com o nome {TxtCatName.Text} salvo em {folderName}. Você deseja substituir?"))
                            File.WriteAllBytes(@$"C:\\Restoranti\\Imagens\\{TxtCatName.Text}.jpg", ms.ToArray());
                    }
                    else
                        File.WriteAllBytes(@$"C:\\Restoranti\\Imagens\\{TxtCatName.Text}.jpg", ms.ToArray());
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao realizar o download da imagem da categoria {TxtCatName.Text}.Exception: {ex.Message} StackTrace: {ex.StackTrace}");
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
                Logger.Write($"Erro ao tentar converter a imagem em bytes.Exception: {ex.Message} StackTrace: {ex.StackTrace}");
                return null;
            }
        }

    }
}
