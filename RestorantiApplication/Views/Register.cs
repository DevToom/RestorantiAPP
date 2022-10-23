using Newtonsoft.Json;
using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities;
using RestorantiApplication.Models.Entities.Constants;
using RestorantiApplication.Models.Enums;
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
    public partial class Register : Form
    {
        //Informação somente para utilizar quando usuário voltar da tela de registro para Login. ( botão voltar )
        private readonly EAcessType _acessType;
        private HttpClient _client;
        string baseUrl = string.Empty;
        public Register(EAcessType acessType)
        {
            this._acessType = acessType;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.LblDateTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //Inicialização de um novo thread para a aplicação não fechar quando der um close().
            var th = new Thread(() => Application.Run(new Login(_acessType)));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            //Fechar tela inicial de carregamento
            this.Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> nullables = new();

                if (String.IsNullOrEmpty(TxtName.Text))
                    nullables.Add("Nome");
                if (String.IsNullOrEmpty(TxtEmail.Text))
                    nullables.Add("Email");
                if (String.IsNullOrEmpty(ChkProfile.Text))
                    nullables.Add("Perfil");
                if (String.IsNullOrEmpty(TxtUser.Text))
                    nullables.Add("Usuário");

                if (!nullables.Any())
                {
                    if (String.IsNullOrEmpty(TxtPassword.Text) || String.IsNullOrEmpty(TxtConfirmPassword.Text) || TxtPassword.Text != TxtConfirmPassword.Text)
                    {
                        ActionsGenerics.ShowMessage("Senhas não coincidente.");
                    }
                    else
                    {
                        if (ActionsGenerics.ConfirmCustom(Constants.CONFIRM_OPERATION))
                        {
                            //Chamar a rota API de register de usuários.
                            _client = new HttpClient();
                            baseUrl = ConfigurationManager.AppSettings["baseUrl"].ToString();
                            bool trustCreate = false;

                            using (var form = new PasswordAdministratorConfirm())
                            {
                                form.ShowDialog();
                                if (form.DialogResult == DialogResult.Yes)
                                    trustCreate = true;
                            }

                            if (trustCreate)
                            {
                                var userInternal = new UserInternal
                                {
                                    Name = TxtName.Text,
                                    Phone = TxtPhone.Text,
                                    Email = TxtEmail.Text,
                                    Profile = (EProfile)ChkProfile.SelectedIndex,
                                    Username = TxtUser.Text,
                                    Password = TxtPassword.Text,
                                    ConfirmPassword = TxtConfirmPassword.Text
                                };

                                var request = JsonConvert.SerializeObject(userInternal);
                                var contentString = new StringContent(request, Encoding.UTF8, "application/json");
                                contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                                HttpResponseMessage result = _client.PostAsync($"{baseUrl}/UserInternal/Create", contentString).Result;

                                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                                {
                                    ActionsGenerics.ShowMessage(result.Content.ReadAsStringAsync().Result);

                                    //Inicialização de um novo thread para a aplicação não fechar quando der um close().
                                    var th = new Thread(() => Application.Run(new Login(_acessType)));
                                    th.SetApartmentState(ApartmentState.STA);
                                    th.Start();

                                    //Fechar tela inicial de carregamento
                                    this.Close();

                                }
                                else
                                    ActionsGenerics.ShowMessage(result.Content.ReadAsStringAsync().Result);
                            }
                        }
                    }
                }
                else
                {
                    string messageError = string.Empty;

                    foreach (var i in nullables)
                    {
                        messageError += i.ToString() + ", ";
                    }

                    messageError = messageError.Substring(0, messageError.Length - 2);

                    ActionsGenerics.ShowMessage($"O(s) campo(s) {messageError} são obrigatórios.");
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro técnico ao criar um usuário novo. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {
            ChkProfile.Items.Clear();
            timer1.Start();
            ChkProfile.Items.AddRange(Enum.GetNames(typeof(EProfile)));
        }

        private void BtnExit2_Click(object sender, EventArgs e)
        {
            try
            {

                if (ActionsGenerics.Exit())
                    this.Close();

            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao encerrar a aplicação. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao minimizar a aplicação. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }
    }
}
