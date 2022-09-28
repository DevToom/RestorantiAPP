using Newtonsoft.Json;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Categorys_Load(object sender, EventArgs e)
        {
            //_client = new HttpClient();
            //HttpResponseMessage result = _client.GetAsync($"{baseUrl}/Category/List").Result;

            //var categorys = JsonConvert.DeserializeObject<List<Category>>(result.Content.ReadAsStringAsync().Result);
            var categorys = new List<Category>();

            for (int i = 1; i < 6; i++)
            {
                categorys.Add(new Category
                {
                    Id = i == 3 ? 50 : i,
                    Name = $"Alfredo " + (i == 3 ? 50 : i),
                    MenuType = EMenuType.Ambos,
                    Status = ECategoryStatus.Ativo
                });
            }

            if (categorys?.Count > 0)
            {
                foreach (var i in categorys)
                {
                    string[] rows = { i.Id.ToString(), i.Name, i.MenuType.ToString(), i.Status.ToString() };

                    //Passar como parâmetro o ID da categoria
                    ListCategorys.Items.Add(new ListViewItem(rows));
                }
            }
        }

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
                        ChkMenuType.Text = i.SubItems[2].Text;

                        //Status da categoria
                        ChkStatus.Text = i.SubItems[3].Text;
                    }

                    BtnUpdate.Text = "Salvar";
                }
                else
                {
                    MessageBox.Show("Selecione uma categoria para conseguir editar!");
                }
            }
            else if (BtnUpdate.Text.Equals("Salvar"))
            {
                MessageBox.Show("Registro alterado com sucesso.");
                BtnUpdate.Text = "Editar";
            }
        }

        private void ListCategorys_Click(object sender, EventArgs e)
        {
            BtnUpdate.Text = "Editar";
            TxtCatName.Text = String.Empty;
            ChkMenuType.Text = String.Empty;
            ChkStatus.Text = String.Empty;
            PbCategory.Image = null;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BtnUpdate.Text = "Editar";
                if (!String.IsNullOrEmpty(TxtCatName.Text) && !String.IsNullOrEmpty(ChkMenuType.Text) && !String.IsNullOrEmpty(ChkStatus.Text))
                {

                    if (MessageBox.Show("Você deseja adicionar o registro?", "Adicionar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //Processo de adicionar no banco.
                        MessageBox.Show("Registro adicionado com sucesso!");
                    }
                    else
                    {
                        //Fechar a modal, não fazer nada.
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                }

            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao adicionar uma nova categoria.Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            BtnUpdate.Text = "Editar";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BtnUpdate.Text = "Editar";
        }

        private void BtnUploadImageCat_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(openFileDialog.FileName);
                    PbCategory.Image = new Bitmap(openFileDialog.FileName);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
