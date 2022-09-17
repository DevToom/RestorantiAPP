using Newtonsoft.Json;
using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities;
using RestorantiApplication.Models.Enums;
using RestorantiApplication.Views.Modals;
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
    public partial class Login : Form
    {
        private readonly EAcessType _acessType;
        private HttpClient _client;
        private readonly static string baseUrl = ConfigurationManager.AppSettings["userInternal"].ToString();
        public Login(EAcessType acessType)
        {
            this._acessType = acessType;
            InitializeComponent();
        }

        private void BtnMinimize1_Click(object sender, EventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {
            if (_acessType == EAcessType.Cashier)
                this.LblAcessType.Text = "Login Caixa";
            else if (_acessType == EAcessType.Kitchen)
                this.LblAcessType.Text = "Login Cozinha";

            timer2.Start();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //Inicialização de um novo thread para a aplicação não fechar quando der um close().
            var th = new Thread(() => Application.Run(new TypeApp()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            //Fechar tela inicial de carregamento
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.LblDateTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Validar se as credenciais foram digitadas...
                if (string.IsNullOrEmpty(TxtUser.Text) || string.IsNullOrEmpty(TxtPassword.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    //Chamar a rota API de register de usuários.
                    _client = new HttpClient();
                    

                    var userInternal = new UserInternal
                    {
                        Username = TxtUser.Text,
                        Password = TxtPassword.Text
                    };

                    var request = JsonConvert.SerializeObject(userInternal);
                    var contentString = new StringContent(request, Encoding.UTF8, "application/json");
                    contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage result = _client.PostAsync($"{baseUrl}/UserInternal/Login", contentString).Result;


                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var userResponse = JsonConvert.DeserializeObject<UserInternal>(result.Content.ReadAsStringAsync().Result);
                        UserLogged.Name = string.IsNullOrEmpty(userResponse.Name) ? "" : userResponse.Name;
                        UserLogged.UserId = userResponse.Id != 0 ? userResponse.Id : 0;

                        //Inicialização de um novo thread para a aplicação não fechar quando der um close().
                        var th = new Thread(() => Application.Run(new MainPage()));
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                        //Fechar tela inicial de carregamento
                        this.Close();
                    }
                    else
                        MessageBox.Show(result.Content.ReadAsStringAsync().Result);
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //Inicialização de um novo thread para a aplicação não fechar quando der um close().
                var th = new Thread(() => Application.Run(new Register(_acessType)));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                //Fechar tela inicial de carregamento
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao tentar acessar a tela de cadastro de usuários. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }

        }

        private void BtnExit2_Click_1(object sender, EventArgs e)
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
    }
}
