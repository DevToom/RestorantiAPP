using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
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
    public partial class RecoveryPasswordStep1 : Form
    {
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
                    //Validar se existe o nome de usuário e o email.


                    //Caso tenha abrir a próxima modal, solicitando a senha administrador.
                    this.Close();

                    var form = new RecoveryPasswordStep2();
                    form.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
