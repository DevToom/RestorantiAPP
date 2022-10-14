using Newtonsoft.Json;
using RestorantiApplication.Generics.Actions;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities;
using RestorantiApplication.Models.Entities.Constants;
using RestorantiApplication.Models.Entities.VM;
using RestorantiApplication.Models.Enums;
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
        private readonly static string baseUrl = ConfigurationManager.AppSettings["baseUrl"].ToString();
        private static List<OrderResponseVM> _orders;
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
                    var orders = JsonConvert.DeserializeObject<List<OrderResponseVM>>(await result.Content.ReadAsStringAsync());
                    _orders = orders;

                    foreach (var i in orders)
                    {
                        Label lblTitleOrder = AddTitleOrder(i);
                        Label lblDescOrder = AddDescOrder(i);
                        Button btnDetails = new Button();
                        if (i.hasObservation)
                            btnDetails = AddBtnObservation(i);
                        Button btnPrepare = AddBtnPrepare(i);
                        GroupBox gpBox = AddGroupBox(i);

                        flowPrepare.Controls.Add(gpBox);
                        gpBox.Controls.Add(lblTitleOrder);
                        gpBox.Controls.Add(lblDescOrder);
                        if (i.hasObservation)
                            gpBox.Controls.Add(btnDetails);
                        gpBox.Controls.Add(btnPrepare);
                        btnPrepare.Click += new System.EventHandler(this.ButtonPreparing_Click);
                    }
                }
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
                            if (btn.Text != "Observação")
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

        private Label AddTitleOrder(OrderResponseVM order)
        {
            Label lbl = new Label();
            lbl.Name = $"lbl1_{order.OrderNumber}";
            lbl.Text = $"Nº {order.OrderNumber}";
            lbl.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.FromArgb(11, 7, 17);
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Margin = new Padding(5);
            lbl.Size = new Size(140, 30);

            return lbl;
        }

        private Label AddDescOrder(OrderResponseVM orders)
        {

            string OrderMessage = string.Empty;

            orders.Products.ForEach(i =>
                OrderMessage += @$"{i.Quantity}x {i.ProductName} {Environment.NewLine}"
            );

            Label lbl = new Label();
            lbl.Name = $"lbl2_{orders.OrderNumber}";
            lbl.Text = OrderMessage;
            lbl.ForeColor = Color.Black;
            lbl.BackColor = Color.White;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Margin = new Padding(5);
            lbl.Padding = new Padding(5);


            return lbl;
        }

        private Button AddBtnObservation(OrderResponseVM order)
        {
            Button btn = new Button();
            btn.Name = $"btn1_{order.OrderNumber}";
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
            try
            {
                Button observation = (Button)sender;
                string orderNumber = observation.Name.Substring(observation.Name.IndexOf("_"), observation.Name.Length - observation.Name.IndexOf("_"));
                orderNumber = orderNumber.Substring(1);

                var orders = _orders.Where(x => x.OrderNumber == orderNumber).FirstOrDefault();
                string msgOrder = string.Empty;

                foreach (var i in orders.Products)
                {
                    if (i.hasObservation)
                    {
                        msgOrder += @$"º{i.ProductName} => {i.Observation}{Environment.NewLine}";
                    }
                }

                MessageBox.Show(@$"OBSERVAÇÕES DO PEDIDO: {Environment.NewLine} {msgOrder}");

            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao encerrar a aplicação COZINHA. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        private Button AddBtnPrepare(OrderResponseVM order)
        {
            Button btn = new Button();
            btn.Name = $"btn2_{order.OrderNumber}";
            btn.Text = "Preparar";
            btn.Dock = DockStyle.Bottom;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            //btn.FlatAppearance.BorderColor = Color.FromArgb(11, 7, 17);
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(11, 7, 17);
            btn.FlatAppearance.MouseOverBackColor = Color.Green;
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 30, 45);
            btn.Size = new Size(232, 30);
            btn.UseVisualStyleBackColor = true;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Margin = new Padding(5);

            return btn;
        }

        private GroupBox AddGroupBox(OrderResponseVM order)
        {
            GroupBox gpBox = new GroupBox();
            gpBox.Location = new System.Drawing.Point(3, 3);
            gpBox.Name = $"gb_{order.OrderNumber}";
            gpBox.Size = new System.Drawing.Size(365, 150);
            gpBox.TabIndex = 0;
            gpBox.TabStop = false;

            return gpBox;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                bool trustLogout = ValidateForExitAndLogout();

                if (trustLogout)
                {
                    if (ActionsGenerics.Exit())
                        this.Close();
                }

            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao encerrar a aplicação COZINHA. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                bool trustLogout = ValidateForExitAndLogout();

                if (trustLogout)
                {
                    if (ActionsGenerics.ConfirmCustom(Constants.CONFIRM_MESSAGE_LOGOUT))
                    {
                        //Reset de usuário global
                        UserLogged.Name = string.Empty;
                        UserLogged.UserId = 0;

                        //Inicialização de um novo thread para a aplicação não fechar quando der um close().
                        var th = new Thread(() => Application.Run(new Login(EAcessType.Kitchen)));
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                        //Fechar tela inicial de carregamento
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao tentar deslogar da conta COZINHA. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
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
                Logger.Write($"Erro ao minimizar a aplicação COZINHA. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
            }
        }

        public bool ValidateForExitAndLogout()
        {
            bool trustLogout = true;
            foreach (Control control in flowPreparing.Controls)
            {
                if (control is GroupBox)
                {
                    ActionsGenerics.ShowMessage("Ainda existe pedido(s) sendo preparado(s). Finalize-os antes para prosseguir");
                    return false;
                }
            }

            if (trustLogout)
            {
                foreach (Control control in flowPrepared.Controls)
                {
                    if (control is GroupBox)
                    {
                        ActionsGenerics.ShowMessage("Ainda existe pedido(s) na fila de preparados. Finalize-os antes para prosseguir");
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
