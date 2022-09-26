using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities;
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

        private void BtnCategorys_Click(object sender, EventArgs e)
        {
            var form = new Categorys { TopLevel = false, TopMost = true };
            this.PanelRender.Controls.Add(form);
            form.Show();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            var form = new Kitchen { TopLevel = false };
            this.PanelRender.Controls.Add(form);
            form.Show();
        }

        private void PanelRender_Leave(object sender, EventArgs e)
        {
            //Lista mock para todos os possíveis forms que poderão estar aberto.
            List<string> strings = new List<string>();
            strings.Add("Categorys");
            strings.Add("Kitchen");

            //Método para validar se está aberto e logo em seguida fechar o form, para liberar recursos.
            CloseAllFormsOpen(strings);
        }

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
    }
}
