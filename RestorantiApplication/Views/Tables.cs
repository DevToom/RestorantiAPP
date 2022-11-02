using Newtonsoft.Json;
using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities;
using RestorantiApplication.Models.Entities.Constants;
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
    public partial class Tables : Form
    {
        private HttpClient _client;
        private readonly static string _baseUrl = ConfigurationManager.AppSettings["baseUrl"].ToString();
        public Tables()
        {
            InitializeComponent();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            try
            {
                //SetAll Enable = false;
                TxtTableNumber.Enabled = false;
                ChkTableStatus.Enabled = false;

                //VisibleAll = True
                foreach (Control c in this.Controls)
                {
                    c.Visible = false;
                }

                //Reset Combobox's
                ChkTableStatus.Items.Clear();

                List<string> statusTables = new List<string>();

                //Get all Status for Tables
                string[] status = Constants.TABLE_STATUS.Split(";");
                foreach (string s in status)
                {
                    statusTables.Add(s);
                }

                //Set list value enum combobox's
                ChkTableStatus.Items.AddRange(statusTables.ToArray());

                //Set value default txtBox/Label
                TxtTableNumber.Text = String.Empty;

                #region GET All - Trazer todos as mesas cadastradas

                _client = new HttpClient();
                HttpResponseMessage result = _client.GetAsync($"{_baseUrl}/Table").Result;

                var tables = JsonConvert.DeserializeObject<List<Table>>(result.Content.ReadAsStringAsync().Result);

                if (tables?.Count > 0)
                {
                    //Clear list before add new itens.
                    ListTables.Items.Clear();
                    foreach (var i in tables)
                    {
                        //Passar como parâmetro o ID da mesa
                        string[] rows = { i.Id.ToString(), i.TableNumber.ToString(), i.TableStatus };

                        ListTables.Items.Add(new ListViewItem(rows));
                    }
                }

                #endregion

                //VisibleAll = True
                foreach (Control c in this.Controls)
                {
                    c.Visible = true;
                }

                LblIdTable.Visible = false;
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao carregar a listagem de mesas na tela inicial. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }


        }

        private void ListTables_Click(object sender, EventArgs e)
        {
            try
            {
                BtnUpdate.Text = "Editar";
                TxtTableNumber.Text = String.Empty;
                ChkTableStatus.Text = String.Empty;
                BtnAdd.Text = "Novo";

                foreach (var i in ListTables.SelectedItems.Cast<ListViewItem>().ToList())
                {
                    ChkTableStatus.SelectedIndex = -1;

                    _client = new HttpClient();

                    //Id da mesa
                    LblIdTable.Text = i.Text;

                    //Número da mesa
                    TxtTableNumber.Text = i.SubItems[1].Text;
                    TxtTableNumber.Enabled = false;

                    //Status da Mesa
                    ChkTableStatus.SelectedIndex = ChkTableStatus.Items.IndexOf(i.SubItems[2].Text);
                    ChkTableStatus.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao carregar um registro mesa ao selecionar uma mesa da lista. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                BtnUpdate.Text = "Editar";

                //Caso o campo nome esteja desabilitado provavelmente todos vão estar. Habilitar
                if (!TxtTableNumber.Enabled)
                {
                    ActionsGenerics.ShowMessage("Habilitando todos os campos de pesquisa!");
                    TxtTableNumber.Enabled = true;
                    ChkTableStatus.Enabled = true;
                }
                else
                {
                    BtnAdd.Text = "Novo";

                    if (
                        string.IsNullOrEmpty(TxtTableNumber.Text) &&
                        string.IsNullOrEmpty(ChkTableStatus.SelectedItem.ToString())
                        )
                        Tables_Load(sender, e);

                    _client = new HttpClient();
                    HttpResponseMessage result;

                    if (string.IsNullOrEmpty(ChkTableStatus.Text))
                        result = _client.GetAsync($"{_baseUrl}/Table/ListWithFilter?TableNumber={Convert.ToInt32(TxtTableNumber.Text)}").Result;
                    else
                        result = _client.GetAsync($"{_baseUrl}/Table/ListWithFilter?TableNumber={Convert.ToInt32(TxtTableNumber.Text)}&Status={ChkTableStatus.Text}").Result;

                    var response = JsonConvert.DeserializeObject<MessageResponse<List<Table>>>(result.Content.ReadAsStringAsync().Result);

                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var tables = response.Entity;

                        if (tables?.Count > 0)
                        {
                            //Clear list before add new itens.
                            ListTables.Items.Clear();
                            foreach (var i in tables)
                            {
                                //Passar como parâmetro o ID da mesa
                                string[] rows = { i.Id.ToString(), i.TableNumber.ToString(), i.TableStatus };
                                ListTables.Items.Add(new ListViewItem(rows));
                            }
                        }
                        else
                        {
                            ActionsGenerics.ShowMessage("Nenhuma mesa encontrada de acordo com os filtros!");
                            Tables_Load(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao pesquisar uma mesa.Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
