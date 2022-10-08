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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;

                //Inicialização de um novo thread para a aplicação não fechar quando der um close().
                var th = new Thread(() => Application.Run(new TypeApp()));
                th.SetApartmentState(ApartmentState.STA); 
                th.Start();

                //Fechar tela inicial de carregamento
                this.Close();
            }
        }
        
    }
}
