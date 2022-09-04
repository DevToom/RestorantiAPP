using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Enums;
using RestorantiApplication.Views.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestorantiApplication.Views
{
    public partial class Login : Form
    {
        private readonly EAcessType _acessType;
        private HttpClient _cliente;
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
            _cliente = new HttpClient();
            var result = _cliente.GetAsync("http://localhost:5202/api/UserInternal/GetUsers").Result;


            var model = result.Content.ReadAsStringAsync();


            //var b = a.Content;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
