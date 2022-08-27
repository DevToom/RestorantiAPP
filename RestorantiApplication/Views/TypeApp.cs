using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models;
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
    public partial class TypeApp : Form
    {

        public TypeApp()
        {
            InitializeComponent();
        }

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
        private void BtnMinimize_Click(object sender, EventArgs e)
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
        private void BtnCashier_Click(object sender, EventArgs e)
        {

            //Inicialização de um novo thread para a aplicação não fechar quando der um close().
            var th = new Thread(() => Application.Run(new Login(EAcessType.Cashier)));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            //Fechar tela inicial de carregamento
            this.Close();

        }
        private void BtnKitchen_Click(object sender, EventArgs e)
        {

            //Inicialização de um novo thread para a aplicação não fechar quando der um close().
            var th = new Thread(() => Application.Run(new Login(EAcessType.Kitchen)));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            //Fechar tela inicial de carregamento
            this.Close();

        }

    }
}
