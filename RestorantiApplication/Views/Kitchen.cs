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
    public partial class Kitchen : Form
    {
        public Kitchen()
        {
            InitializeComponent();
        }

        private void Kitchen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                
                Label lblTitleOrder = AddTitleOrder(i);
                Label lblDescOrder = AddDescOrder(i);
                Button btnDetails = AddBtnDetails(i);
                Button btnPrepare = AddBtnPrepare(i);
                GroupBox gpBox = AddGroupBox(i);

                flowLayoutPanel1.Controls.Add(gpBox);
                gpBox.Controls.Add(lblTitleOrder);
                gpBox.Controls.Add(lblDescOrder);
                gpBox.Controls.Add(btnDetails);
                gpBox.Controls.Add(btnPrepare);
                btnPrepare.Click += new System.EventHandler(this.Button_Click);

            }
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            GroupBox groupBox = new GroupBox();
            Button InfoButton = (Button)sender;

            //Mandar para grid de preparo
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is GroupBox)
                {
                    if (control.Name.Substring(control.Name.IndexOf("_")+1) == InfoButton.Name.Substring(InfoButton.Name.IndexOf("_")+1))
                    {
                        groupBox = (GroupBox)control;
                        break;
                    }
                }
            }

            flowLayoutPanel2.Controls.Add(groupBox);
            MessageBox.Show("Status do pedido alterado.");
        }

        private Label AddTitleOrder(int count)
        {
            Label lbl = new Label();
            lbl.Name = $"lbl1{count}";
            lbl.Text = $"Pedido nº{count}";
            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.Blue;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Margin = new Padding(5);

            return lbl; 
        }

        private Label AddDescOrder(int count)
        {
            Label lbl = new Label();
            lbl.Name = $"lbl2{count}";
            lbl.Text = $@"1X X-Salada {Environment.NewLine}1x Refrigerante Coca-Cola";
            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.Green;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Margin = new Padding(5);
            lbl.Padding = new Padding(5);


            return lbl;
        }

        private Button AddBtnDetails(int count)
        {
            Button btn = new Button();
            btn.Name = $"btn1{count}";
            btn.Text = "Detalhes";
            btn.Dock = DockStyle.Bottom;
            btn.ForeColor = Color.Black;
            btn.Size = new Size(232, 30);
            btn.UseVisualStyleBackColor = true;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Margin = new Padding(5);

            return btn;
        }

        private Button AddBtnPrepare(int count)
        {
            Button btn = new Button();
            btn.Name = $"btn_{count}";
            btn.Text = "Preparar";
            btn.Dock = DockStyle.Bottom;
            btn.ForeColor = Color.Black;
            btn.Size = new Size(232, 30);
            btn.UseVisualStyleBackColor = true;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Margin = new Padding(5);

            return btn;
        }

        private GroupBox AddGroupBox(int count)
        {
            GroupBox gpBox = new GroupBox();
            gpBox.Location = new System.Drawing.Point(3, 3);
            gpBox.Name = $"gb_{count}";
            gpBox.Size = new System.Drawing.Size(231, 231);
            gpBox.TabIndex = 0;
            gpBox.TabStop = false;
            gpBox.Text = "GroupBoxAdd";

            return gpBox;
        }

    }
}
