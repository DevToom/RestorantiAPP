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
    public partial class RecoveryPasswordStep3 : Form
    {
        public RecoveryPasswordStep3()
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

        private void BtnConfirmPassword_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text != TxtConfirmPassword.Text)
            {
                MessageBox.Show("Senhas divergentes, verifque!");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                MessageBox.Show("Senha alterada com sucesso.");
            }
        }
    }
}
