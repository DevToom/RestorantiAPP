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
    public partial class RecoveryPasswordStep2 : Form
    {
        private HttpClient _client;
        private readonly static string baseUrl = ConfigurationManager.AppSettings["baseUrl"].ToString();
        private UserValidateRecoveryPassword _userValidateRecoveryPassword;
        public RecoveryPasswordStep2(UserValidateRecoveryPassword userValidateRecoveryPassword)
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

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtAdmPassoword.Text))
            {
                MessageBox.Show("Favor informar uma senha válida!");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                _client = new HttpClient();

                HttpResponseMessage result = _client.PostAsync($"{baseUrl}/UserInternal/recoverypassword/validatepasswordconfirm/{TxtAdmPassoword.Text}", null).Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //Caso retorno seja um 200, deve prosseguir ao step 3 onde irá ocorrer a alteração da senha. OBS: Dispose para liberar o recurso da modal atual.
                    this.Dispose(true);

                    var form = new RecoveryPasswordStep3(_userValidateRecoveryPassword);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show(result.Content.ReadAsStringAsync().Result);
                    TxtAdmPassoword.Text = String.Empty;
                    this.DialogResult = DialogResult.None;
                }
            }
        }
    }
}
