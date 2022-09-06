namespace RestorantiApplication.Views
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnExit2 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblAcessType = new System.Windows.Forms.Label();
            this.BtnMinimize1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKitchen = new System.Windows.Forms.Button();
            this.BtnCashier = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnResetPassword = new System.Windows.Forms.Button();
            this.LblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblDateTimeNow = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnMinimize);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 56);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.BtnExit2);
            this.panel2.Controls.Add(this.BtnBack);
            this.panel2.Controls.Add(this.LblAcessType);
            this.panel2.Controls.Add(this.BtnMinimize1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnKitchen);
            this.panel2.Controls.Add(this.BtnCashier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 56);
            this.panel2.TabIndex = 3;
            // 
            // BtnExit2
            // 
            this.BtnExit2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnExit2.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit2.FlatAppearance.BorderSize = 0;
            this.BtnExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit2.Font = new System.Drawing.Font("Aleo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit2.ForeColor = System.Drawing.Color.Transparent;
            this.BtnExit2.Location = new System.Drawing.Point(1220, 12);
            this.BtnExit2.Name = "BtnExit2";
            this.BtnExit2.Size = new System.Drawing.Size(35, 28);
            this.BtnExit2.TabIndex = 6;
            this.BtnExit2.Text = "x";
            this.BtnExit2.UseVisualStyleBackColor = true;
            this.BtnExit2.Click += new System.EventHandler(this.BtnExit2_Click_1);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(24, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(105, 34);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Voltar";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblAcessType
            // 
            this.LblAcessType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblAcessType.AutoSize = true;
            this.LblAcessType.Font = new System.Drawing.Font("Aleo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAcessType.ForeColor = System.Drawing.Color.White;
            this.LblAcessType.Location = new System.Drawing.Point(592, 13);
            this.LblAcessType.Name = "LblAcessType";
            this.LblAcessType.Size = new System.Drawing.Size(58, 23);
            this.LblAcessType.TabIndex = 4;
            this.LblAcessType.Text = "Login";
            // 
            // BtnMinimize1
            // 
            this.BtnMinimize1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnMinimize1.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize1.BackgroundImage = global::RestorantiApplication.Properties.Resources.minimize61;
            this.BtnMinimize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMinimize1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMinimize1.FlatAppearance.BorderSize = 0;
            this.BtnMinimize1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMinimize1.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimize1.Location = new System.Drawing.Point(1177, 18);
            this.BtnMinimize1.Name = "BtnMinimize1";
            this.BtnMinimize1.Size = new System.Drawing.Size(27, 22);
            this.BtnMinimize1.TabIndex = 3;
            this.BtnMinimize1.Text = "-";
            this.BtnMinimize1.UseVisualStyleBackColor = true;
            this.BtnMinimize1.Click += new System.EventHandler(this.BtnMinimize1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(941, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "ESCOLHA O AMBIENTE DE ACESSO";
            // 
            // BtnKitchen
            // 
            this.BtnKitchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnKitchen.BackgroundImage = global::RestorantiApplication.Properties.Resources.Cozinha;
            this.BtnKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKitchen.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnKitchen.Location = new System.Drawing.Point(1247, 174);
            this.BtnKitchen.Name = "BtnKitchen";
            this.BtnKitchen.Size = new System.Drawing.Size(303, 216);
            this.BtnKitchen.TabIndex = 1;
            this.BtnKitchen.Text = "COZINHA";
            this.BtnKitchen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnKitchen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnKitchen.UseVisualStyleBackColor = true;
            // 
            // BtnCashier
            // 
            this.BtnCashier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCashier.BackgroundImage = global::RestorantiApplication.Properties.Resources.Caixa;
            this.BtnCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCashier.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCashier.Location = new System.Drawing.Point(755, 174);
            this.BtnCashier.Name = "BtnCashier";
            this.BtnCashier.Size = new System.Drawing.Size(296, 216);
            this.BtnCashier.TabIndex = 0;
            this.BtnCashier.Text = "CAIXA";
            this.BtnCashier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCashier.UseVisualStyleBackColor = true;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.BackgroundImage = global::RestorantiApplication.Properties.Resources.minimize6;
            this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.Location = new System.Drawing.Point(2256, -4);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(27, 22);
            this.BtnMinimize.TabIndex = 1;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Location = new System.Drawing.Point(2301, -10);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(35, 28);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.TxtPassword);
            this.panel3.Controls.Add(this.TxtUser);
            this.panel3.Controls.Add(this.BtnLogin);
            this.panel3.Controls.Add(this.BtnRegister);
            this.panel3.Controls.Add(this.BtnResetPassword);
            this.panel3.Controls.Add(this.LblPassword);
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 664);
            this.panel3.TabIndex = 2;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPassword.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.Location = new System.Drawing.Point(437, 311);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(373, 27);
            this.TxtPassword.TabIndex = 12;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtUser
            // 
            this.TxtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUser.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUser.Location = new System.Drawing.Point(437, 233);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(373, 27);
            this.TxtUser.TabIndex = 11;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(646, 389);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(164, 39);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(437, 389);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(169, 39);
            this.BtnRegister.TabIndex = 7;
            this.BtnRegister.Text = "Cadastrar";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnResetPassword
            // 
            this.BtnResetPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnResetPassword.FlatAppearance.BorderSize = 0;
            this.BtnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetPassword.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnResetPassword.ForeColor = System.Drawing.Color.White;
            this.BtnResetPassword.Location = new System.Drawing.Point(437, 340);
            this.BtnResetPassword.Name = "BtnResetPassword";
            this.BtnResetPassword.Size = new System.Drawing.Size(177, 30);
            this.BtnResetPassword.TabIndex = 6;
            this.BtnResetPassword.Text = "Esqueci minha senha";
            this.BtnResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnResetPassword.UseVisualStyleBackColor = true;
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPassword.ForeColor = System.Drawing.Color.White;
            this.LblPassword.Location = new System.Drawing.Point(437, 280);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 19);
            this.LblPassword.TabIndex = 5;
            this.LblPassword.Text = "Senha";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(437, 204);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(66, 19);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::RestorantiApplication.Properties.Resources.Logo300x2001;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(424, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 152);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LblDateTimeNow);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 593);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1280, 71);
            this.panel4.TabIndex = 0;
            // 
            // LblDateTimeNow
            // 
            this.LblDateTimeNow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblDateTimeNow.AutoSize = true;
            this.LblDateTimeNow.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDateTimeNow.ForeColor = System.Drawing.Color.White;
            this.LblDateTimeNow.Location = new System.Drawing.Point(24, 23);
            this.LblDateTimeNow.Name = "LblDateTimeNow";
            this.LblDateTimeNow.Size = new System.Drawing.Size(43, 19);
            this.LblDateTimeNow.TabIndex = 0;
            this.LblDateTimeNow.Text = "Date";
            this.LblDateTimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button BtnMinimize;
        private Button BtnExit;
        private Panel panel2;
        private Label label1;
        private Button BtnKitchen;
        private Button BtnCashier;
        private Button BtnMinimize1;
        private Label LblAcessType;
        private Button BtnBack;
        private Panel panel3;
        private Panel panel4;
        private System.Windows.Forms.Timer timer2;
        private Label LblDateTimeNow;
        private Label LblPassword;
        private Label lblUser;
        private PictureBox pictureBox1;
        private Button BtnResetPassword;
        private Button BtnLogin;
        private Button BtnRegister;
        private TextBox TxtUser;
        private TextBox TxtPassword;
        private Button BtnExit2;
    }
}