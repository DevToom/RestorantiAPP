using Newtonsoft.Json;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;

namespace RestorantiApplication.Views
{
    public partial class Categorys : Form
    {
        private HttpClient _client;
        private readonly static string baseUrl = ConfigurationManager.AppSettings["category"].ToString();
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
            HttpResponseMessage result = _client.GetAsync($"{baseUrl}/Category").Result;

            var categorys = JsonConvert.DeserializeObject<List<Category>>(result.Content.ReadAsStringAsync().Result);

            if (categorys?.Count > 0)
            {
                //Clear list before add new itens.
                ListCategorys.Items.Clear();
                foreach (var i in categorys)
                {
                    //Passar como parâmetro o ID da categoria
                    string[] rows = { i.Id.ToString(), i.Name, i.MenuType.ToString(), i.Status.ToString(), Encoding.ASCII.GetString(i.ImageContent) };

                    ListCategorys.Items.Add(new ListViewItem(rows));
                }
            }
        }

        /// <summary>
        /// Botão de Editar/Salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
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
                    BtnUploadImageCat.Enabled = true;

                    BtnUpdate.Text = "Salvar";
                }
                else
                {
                    MessageBox.Show("Selecione uma categoria para conseguir editar!");
                }
            }
            else if (BtnUpdate.Text.Equals("Salvar"))
            {
                _client = new HttpClient();
                byte[] imageContent = null;

                //Validar se fez o upload de uma imagem
                if (PbCategory.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        PbCategory.Image.Save(ms, PbCategory.Image.RawFormat);
                        imageContent = ms.ToArray();
                    }
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

                HttpResponseMessage result = _client.PostAsync($"{baseUrl}/Category/Update", contentString).Result;
                var response = JsonConvert.DeserializeObject<MessageResponse<Category>>(result.Content.ReadAsStringAsync().Result);
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.Message);
                    BtnUpdate.Text = "Editar";
                    Categorys_Load(sender, e);
                }
            }
        }

        /// <summary>
        /// Quando clicar sobre o ID de qualquer registro da tabela, preencher todos os campos do formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCategorys_Click(object sender, EventArgs e)
        {
            BtnUpdate.Text = "Editar";
            TxtCatName.Text = String.Empty;
            ChkMenuType.Text = String.Empty;
            ChkStatus.Text = String.Empty;
            PbCategory.Image = null;

            foreach (var i in ListCategorys.SelectedItems.Cast<ListViewItem>().ToList())
            {
                ChkMenuType.SelectedIndex = -1;
                ChkStatus.SelectedIndex = -1;

                _client = new HttpClient();
                HttpResponseMessage result = _client.GetAsync($"{baseUrl}/Category/GetImage/{Convert.ToInt32(i.Text)}").Result;

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
                    using (var memoryStream = new MemoryStream(category.ImageContent))
                    {
                        PbCategory.Image = Image.FromStream(memoryStream, true);
                        BtnUploadImageCat.Enabled = false;
                    }
                }
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
                if (BtnUpdate.Text == "Salvar")
                {
                    if (MessageBox.Show("Você deseja continuar com a criação de uma nova categoria?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //Adicionar um registro com base nas mesmas informações porém um novo usuário.
                        _client = new HttpClient();
                        byte[] imageContent = null;

                        //Validar se fez o upload de uma imagem
                        if (PbCategory.Image != null)
                        {
                            using (var ms = new MemoryStream())
                            {
                                PbCategory.Image.Save(ms, PbCategory.Image.RawFormat);
                                imageContent = ms.ToArray();
                            }
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

                        HttpResponseMessage result = _client.PostAsync($"{baseUrl}/Category", contentString).Result;
                        var response = JsonConvert.DeserializeObject<MessageResponse<Category>>(result.Content.ReadAsStringAsync().Result);
                        if (result.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show(response.Message);

                            //Após salvar o registro zerar todos os campos e atualizar a lista
                            BtnUpdate.Text = "Editar";
                            TxtCatName.Text = string.Empty;
                            ChkMenuType.Text = string.Empty;
                            ChkStatus.Text = string.Empty;
                            PbCategory.Image = null;

                            //Carregar a lista.
                            Categorys_Load(sender, e);
                        }
                        else
                            MessageBox.Show(response.Message);
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(TxtCatName.Text) && !String.IsNullOrEmpty(ChkMenuType.Text) && !String.IsNullOrEmpty(ChkStatus.Text))
                    {
                        if (MessageBox.Show("Você deseja adicionar o registro?", "Adicionar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            //Processo de adicionar no banco.
                            _client = new HttpClient();
                            byte[] imageContent = null;

                            //Validar se fez o upload de uma imagem
                            if (PbCategory.Image != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    PbCategory.Image.Save(ms, PbCategory.Image.RawFormat);
                                    imageContent = ms.ToArray();
                                }
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

                            HttpResponseMessage result = _client.PostAsync($"{baseUrl}/Category", contentString).Result;
                            var response = JsonConvert.DeserializeObject<MessageResponse<Category>>(result.Content.ReadAsStringAsync().Result);
                            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                //Após salvar o registro zerar todos os campos e atualizar a lista
                                BtnUpdate.Text = "Editar";
                                TxtCatName.Text = string.Empty;
                                ChkMenuType.Text = string.Empty;
                                ChkStatus.Text = string.Empty;
                                PbCategory.Image = null;

                                //Carregar a lista.
                                Categorys_Load(sender, e);
                                MessageBox.Show(response.Message);
                            }
                            else
                                MessageBox.Show(response.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos!");
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
            BtnUpdate.Text = "Editar";

            var listOfAllSelected = ListCategorys.SelectedItems.Cast<ListViewItem>().ToList();
            if (listOfAllSelected?.Count > 0)
            {
                foreach (var i in listOfAllSelected)
                {
                    //Id da categoria
                    lblIdCategory.Text = i.Text;
                }

                _client = new HttpClient();
                HttpResponseMessage result = _client.DeleteAsync($"{baseUrl}/Category/Delete/{Convert.ToInt32(lblIdCategory.Text)}").Result;
                var response = JsonConvert.DeserializeObject<MessageResponse<Category>>(result.Content.ReadAsStringAsync().Result);
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.Message);
                    Categorys_Load(sender, e);

                    TxtCatName.Enabled = true;
                    ChkMenuType.Enabled = true;
                    ChkStatus.Enabled = true;
                    BtnUploadImageCat.Enabled = true;
                }
                else
                    MessageBox.Show(response.Message);
            }
            else
            {
                MessageBox.Show("Selecione uma categoria para conseguir editar!");
            }
        }


        /// <summary>
        /// Botão de Pesquisar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BtnUpdate.Text = "Editar";

            //Caso o campo nome esteja desabilitado provavelmente todos vão estar. Habilitar
            if (!TxtCatName.Enabled)
            {
                MessageBox.Show("Habilitando todos os campos de pesquisa!");
                TxtCatName.Enabled = true;
                ChkMenuType.Enabled = true;
                ChkStatus.Enabled = true;
                BtnUploadImageCat.Enabled = true;
            }
            else
            {
                if (
                    string.IsNullOrEmpty(TxtCatName.Text) &&
                    string.IsNullOrEmpty(ChkMenuType.SelectedItem.ToString()) &&
                    string.IsNullOrEmpty(ChkStatus.SelectedItem.ToString())
                    )
                    Categorys_Load(sender, e);

                _client = new HttpClient();
                HttpResponseMessage result;

                if (string.IsNullOrEmpty(TxtCatName.Text))
                    result = _client.GetAsync($"{baseUrl}/Category/ListWithFilter?MenuType={ChkMenuType.SelectedIndex}&Status={ChkStatus.SelectedIndex}").Result;
                else
                    result = _client.GetAsync($"{baseUrl}/Category/ListWithFilter?MenuType={ChkMenuType.SelectedIndex}&Status={ChkStatus.SelectedIndex}&Name={TxtCatName.Text}").Result;

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
                            string[] rows = { i.Id.ToString(), i.Name, i.MenuType.ToString(), i.Status.ToString(), Encoding.ASCII.GetString(i.ImageContent) };
                            ListCategorys.Items.Add(new ListViewItem(rows));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma categoria encontrada de acordo com os filtros!");
                        Categorys_Load(sender, e);
                    }
                }
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

                    ////Chamar a rota API de register de usuários.
                    //_client = new HttpClient();


                    //var category = new Category
                    //{
                    //    Name = TxtCatName.Text,
                    //    ImageContent = imgBytes,
                    //    MenuType = (EMenuType)Convert.ToInt32(ChkMenuType.SelectedItem),
                    //    Status = (ECategoryStatus)Convert.ToInt32(ChkStatus.SelectedItem),
                    //    CreationDate = DateTime.Now,
                    //    CreationUserId = UserLogged.UserId
                    //};

                    //var request = JsonConvert.SerializeObject(category);
                    //var contentString = new StringContent(request, Encoding.UTF8, "application/json");
                    //contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    //HttpResponseMessage result = _client.PostAsync($"{baseUrl}/Category", contentString).Result;

                    //if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    //{
                    //    Categorys_Load(sender, e);
                    //}
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
