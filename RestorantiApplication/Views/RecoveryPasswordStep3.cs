using Newtonsoft.Json;
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
    public partial class RecoveryPasswordStep3 : Form
    {
        private HttpClient _client;
        private readonly static string baseUrl = ConfigurationManager.AppSettings["baseUrl"].ToString();
        private UserValidateRecoveryPassword _userValidateRecoveryPassword;
        public RecoveryPasswordStep3(UserValidateRecoveryPassword userValidateRecoveryPassword)
        {
            InitializeComponent();
            this._userValidateRecoveryPassword = userValidateRecoveryPassword;
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

        private void BtnConfirmPassword_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text != TxtConfirmPassword.Text || String.IsNullOrEmpty(TxtPassword.Text) || String.IsNullOrEmpty(TxtConfirmPassword.Text))
            {
                MessageBox.Show("Senhas divergentes e/ou inválidas, verifque!");
                TxtPassword.Text = String.Empty;
                TxtConfirmPassword.Text = String.Empty;
                this.DialogResult = DialogResult.None;
            }
            else
            {
                _userValidateRecoveryPassword.Password = TxtPassword.Text;
                _userValidateRecoveryPassword.ConfirmPassword = TxtConfirmPassword.Text;

                var request = JsonConvert.SerializeObject(_userValidateRecoveryPassword);
                var contentString = new StringContent(request, Encoding.UTF8, "application/json");
                contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                _client = new HttpClient();

                HttpResponseMessage result = _client.PostAsync($"{baseUrl}/UserInternal/recoverypassword/updatepasswordconfirm", contentString).Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(result.Content.ReadAsStringAsync().Result);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Content.ReadAsStringAsync().Result);
                    TxtPassword.Text = String.Empty;
                    TxtConfirmPassword.Text = String.Empty;
                    this.DialogResult = DialogResult.None;
                }


                
            }
        }
    }
}
