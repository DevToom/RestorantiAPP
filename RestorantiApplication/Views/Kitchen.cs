using Newtonsoft.Json;
using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities;
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
    
    public partial class Kitchen : Form
    {
        private HttpClient _client = new HttpClient();
        private readonly static string baseUrl = ConfigurationManager.AppSettings["order"].ToString();
        public Kitchen()
        {
            InitializeComponent();
        }

        private async void Kitchen_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage result = _client.GetAsync($"{baseUrl}/Order/GetListOrder").Result;//_client.PostAsync($"{baseUrl}/UserInternal/Login", contentString).Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var orders = JsonConvert.DeserializeObject<List<Order>>(await result.Content.ReadAsStringAsync());
                    foreach (var i in orders)
                    {
                        Label lblTitleOrder = AddTitleOrder(i);
                        Label lblDescOrder = AddDescOrder(i);
                        Button btnDetails = AddBtnObservation(i);
                        Button btnPrepare = AddBtnPrepare(i);
                        GroupBox gpBox = AddGroupBox(i);

                        flowPrepare.Controls.Add(gpBox);
                        gpBox.Controls.Add(lblTitleOrder);
                        gpBox.Controls.Add(lblDescOrder);
                        gpBox.Controls.Add(btnDetails);
                        gpBox.Controls.Add(btnPrepare);
                        btnPrepare.Click += new System.EventHandler(this.ButtonPreparing_Click);
                    }

                }

                //    for (int i = 0; i < 10; i++)
                //{

                //    Label lblTitleOrder = AddTitleOrder(i);
                //    Label lblDescOrder = AddDescOrder(i);
                //    Button btnDetails = AddBtnObservation(i);
                //    Button btnPrepare = AddBtnPrepare(i);
                //    GroupBox gpBox = AddGroupBox(i);

                //    flowPrepare.Controls.Add(gpBox);
                //    gpBox.Controls.Add(lblTitleOrder);
                //    gpBox.Controls.Add(lblDescOrder);
                //    gpBox.Controls.Add(btnDetails);
                //    gpBox.Controls.Add(btnPrepare);
                //    btnPrepare.Click += new System.EventHandler(this.ButtonPreparing_Click);

                //}
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        /// <summary>
        /// Ao clicar no botão de preparar um pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPreparing_Click(object? sender, EventArgs e)
        {
            GroupBox groupBox = new GroupBox();
            Button InfoButton = (Button)sender;
            bool hasPreparing = false;
            //Mandar para grid de preparo
            foreach (Control control in flowPrepare.Controls)
            {
                if (control is GroupBox)
                {
                    if (control.Name.Substring(control.Name.IndexOf("_") + 1) == InfoButton.Name.Substring(InfoButton.Name.IndexOf("_") + 1))
                    {
                        foreach (Button btn in control.Controls.OfType<Button>())
                        {
                            if (btn.Name.Contains("_"))
                            {
                                btn.Text = "Finalizar";
                                btn.Click += new System.EventHandler(this.ButtonPrepared_Click);
                                groupBox = (GroupBox)control;
                                hasPreparing = true;
                                break;
                            }
                        }
                        break;
                    }
                }
            }

            if (hasPreparing)
                flowPreparing.Controls.Add(groupBox);

        }

        /// <summary>
        /// Ao clicar no botão de finalizar pedido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ButtonPrepared_Click(object? sender, EventArgs e)
        {
            GroupBox groupBox = new GroupBox();
            Button InfoButton = (Button)sender;
            bool hasPrepared = false;
            foreach (Control control in flowPreparing.Controls)
            {
                if (control is GroupBox)
                {
                    if (control.Name.Substring(control.Name.IndexOf("_") + 1) == InfoButton.Name.Substring(InfoButton.Name.IndexOf("_") + 1))
                    {
                        foreach (Button btn in control.Controls.OfType<Button>())
                        {
                            if (btn.Name.Contains("_"))
                            {
                                btn.Text = "Preparado";
                                btn.Visible = false;
                                //btn.Click += new System.EventHandler(this.ButtonPrepared_Click);
                                groupBox = (GroupBox)control;
                                hasPrepared = true;
                                break;
                            }
                        }
                        break;
                    }
                }
            }

            if (hasPrepared)
                flowPrepared.Controls.Add(groupBox);
        }

        private Label AddTitleOrder(Order order)
        {
            Label lbl = new Label();
            lbl.Name = $"lbl1_{order.OrderId}";
            lbl.Text = $"Nº {order.OrderId}";
            lbl.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.FromArgb(11, 7, 17);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Margin = new Padding(5);

            return lbl;
        }

        private Label AddDescOrder(Order order)
        {

            string OrderMessage = string.Empty;

            order.Itens.ForEach(i =>
                OrderMessage += @$"{i.Quantity}x {i.Name} {Environment.NewLine}"
            );

            Label lbl = new Label();
            lbl.Name = $"lbl2_{order.OrderId}";
            lbl.Text = OrderMessage;
            lbl.ForeColor = Color.Black;
            lbl.BackColor = Color.White;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Margin = new Padding(5);
            lbl.Padding = new Padding(5);


            return lbl;
        }

        private Button AddBtnObservation(Order order)
        {
            Button btn = new Button();
            btn.Name = $"btn1_{order.OrderId}";
            btn.Text = "Observação";
            btn.Dock = DockStyle.Bottom;
            btn.ForeColor = Color.Black;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.Orange;
            btn.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btn.FlatAppearance.MouseDownBackColor = Color.DarkOrange;

            btn.Size = new Size(232, 30);
            btn.UseVisualStyleBackColor = true;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Margin = new Padding(5);
            btn.Click += new System.EventHandler(this.ButtonObservation_Click);

            return btn;
        }

        private void ButtonObservation_Click(object? sender, EventArgs e)
        {
            //Mostrar a modal com a informação.
        }

        private Button AddBtnPrepare(Order order)
        {
            Button btn = new Button();
            btn.Name = $"btn2_{order.OrderId}";
            btn.Text = "Preparar";
            btn.Dock = DockStyle.Bottom;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            //btn.FlatAppearance.BorderColor = Color.FromArgb(11, 7, 17);
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(11, 7, 17);
            btn.FlatAppearance.MouseOverBackColor = Color.Green;
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(32,30,45);
            btn.Size = new Size(232, 30);
            btn.UseVisualStyleBackColor = true;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Margin = new Padding(5);

            return btn;
        }

        private GroupBox AddGroupBox(Order order)
        {
            GroupBox gpBox = new GroupBox();
            gpBox.Location = new System.Drawing.Point(3, 3);
            gpBox.Name = $"gb_{order.OrderId}";
            gpBox.Size = new System.Drawing.Size(365, 150);
            gpBox.TabIndex = 0;
            gpBox.TabStop = false;
            gpBox.Text = "GroupBoxAdd";

            return gpBox;
        }

        private void button2_Click(object sender, EventArgs e)
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
