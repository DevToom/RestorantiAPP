using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities;
using RestorantiApplication.Models.Entities.Constants;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            LblUserLogged.Text = $"Olá, {UserLogged.Name}";
        }

        /// <summary>
        /// Cadastro de Categorias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCategorys_Click(object sender, EventArgs e)
        {
            var form = new Categorys { TopLevel = false, TopMost = true };
            this.PanelRender.Controls.Add(form);
            form.Show();
        }

        /// <summary>
        /// Cadastro de produtos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProducts_Click(object sender, EventArgs e)
        {
            var form = new Products { TopLevel = false };
            this.PanelRender.Controls.Add(form);
            form.Show();
        }

        /// <summary>
        /// RENDERIZAR NO PANEL APENAS A VIEW SOLICITADA, As demais serão fechadas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelRender_Leave(object sender, EventArgs e)
        {
            //Lista mock para todos os possíveis forms que poderão estar aberto.
            var strings = Constants.MAIN_PAGE_FORMS_OPEN.Split(";").ToList();

            //Método para validar se está aberto e logo em seguida fechar o form, para liberar recursos.
            CloseAllFormsOpen(strings);
        }

        /// <summary>
        /// Método para fechar todos os formulários abertos.
        /// </summary>
        /// <param name="list"></param>
        public void CloseAllFormsOpen(List<string> list)
        {
            var listForms = Application.OpenForms.Cast<Form>().ToList();
            if (listForms.Count > 1)
            {
                foreach (var form in list)
                {
                    var formOpen = Application.OpenForms.Cast<Form>().Where(x => x.Name == form).FirstOrDefault();
                    if (formOpen != null)
                        formOpen.Dispose();
                }
            }
        }

        /// <summary>
        /// Minizar aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Método para fechar o aplicativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Método para deslogar da conta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActionsGenerics.ConfirmCustom(Constants.CONFIRM_MESSAGE_LOGOUT))
                {
                    //Reset de usuário global
                    UserLogged.Name = string.Empty;
                    UserLogged.UserId = 0;

                    //Inicialização de um novo thread para a aplicação não fechar quando der um close().
                    var th = new Thread(() => Application.Run(new Login(Models.Enums.EAcessType.Cashier)));
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                    //Fechar tela inicial de carregamento
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao tentar deslogar da conta. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void BtnTables_Click(object sender, EventArgs e)
        {
            var form = new Tables { TopLevel = false };
            this.PanelRender.Controls.Add(form);
            form.Show();
        }

        private void BtnAccountManager_Click(object sender, EventArgs e)
        {

        }
    }
}
