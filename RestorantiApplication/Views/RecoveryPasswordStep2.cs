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
    public partial class RecoveryPasswordStep2 : Form
    {
        public RecoveryPasswordStep2()
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
            if (String.IsNullOrEmpty(TxtAdmPassoword.Text))
            {
                MessageBox.Show("Favor informar uma senha válida!");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                //Validar se a senha é de fato uma senha do administrador.

                //Caso for enviar para o próximo step.
                this.Close();

                var form = new RecoveryPasswordStep3();
                form.ShowDialog();
            }
        }
    }
}
