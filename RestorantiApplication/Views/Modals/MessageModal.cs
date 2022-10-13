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

namespace RestorantiApplication.Views.Modals
{
    public partial class MessageModal : Form
    {
        private readonly string _Message;
        public MessageModal(string Message)
        {
            InitializeComponent();
            this._Message = Message;
        }

        private void MessageModal_Load(object sender, EventArgs e)
        {
            try
            {
                TxtMessage.Text = _Message;
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro técnico ao exibir a modal de aviso custom. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }
    }
}
