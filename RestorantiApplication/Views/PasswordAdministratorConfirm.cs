using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
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
    public partial class PasswordAdministratorConfirm : Form
    {
        private HttpClient _client;
        string baseUrl = string.Empty;
        public PasswordAdministratorConfirm()
        {
            InitializeComponent();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(TxtPasswordAdmin.Text))
                {
                    _client = new HttpClient();
                    baseUrl = ConfigurationManager.AppSettings["baseUrl"].ToString();
                    HttpResponseMessage result = _client.PostAsync($"{baseUrl}/UserInternal/PasswordAdministratorConfirm/{TxtPasswordAdmin.Text}", null).Result;
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                        this.button1_Click(sender, e);
                    else
                        ActionsGenerics.ShowMessage(result.Content.ReadAsStringAsync().Result);
                }
                else
                    ActionsGenerics.ShowMessage("Digite uma senha!");
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro no processo de validação de senha administradora. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao encerrar a aplicação. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }
    }
}
