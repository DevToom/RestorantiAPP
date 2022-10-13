using Newtonsoft.Json;
using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestorantiApplication.Views
{
    public partial class RecoveryPasswordStep1 : Form
    {
        private HttpClient _client;
        private readonly static string baseUrl = ConfigurationManager.AppSettings["baseUrl"].ToString();
        public RecoveryPasswordStep1()
        {
            InitializeComponent();
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

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(TxtUser.Text)
                    ||
                    String.IsNullOrEmpty(TxtEmail.Text)
                    )
                {
                    MessageBox.Show("Preencha todos os campos!");

                    //Setado o dialogResult para None para não fechar a modal ao clicar em OK.
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    var userValidateRecoveryPassword = new UserValidateRecoveryPassword
                    {
                        Username = TxtUser.Text,
                        Email = TxtEmail.Text
                    };

                    var request = JsonConvert.SerializeObject(userValidateRecoveryPassword);
                    var contentString = new StringContent(request, Encoding.UTF8, "application/json");
                    contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    _client = new HttpClient();

                    HttpResponseMessage result = _client.PostAsync($"{baseUrl}/UserInternal/recoverypassword/validate", contentString).Result;

                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        //Caso retorno seja um 200, deve solicitar a senha administrador para prosseguir. OBS: Dispose para liberar o recurso da modal atual.
                        this.Dispose(true);

                        var form = new RecoveryPasswordStep2(userValidateRecoveryPassword);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(result.Content.ReadAsStringAsync().Result);
                        TxtUser.Text = String.Empty;
                        TxtEmail.Text = String.Empty;
                        this.DialogResult = DialogResult.None;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao encerrar ao executar o step1 do esqueceu senha. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }
    }
}
