namespace RestorantiApplication.Views
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelRender = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LblUserLogged = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMinimize1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnCategorys = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.PanelRender);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 0;
            // 
            // PanelRender
            // 
            this.PanelRender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.PanelRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRender.Location = new System.Drawing.Point(204, 56);
            this.PanelRender.Margin = new System.Windows.Forms.Padding(0);
            this.PanelRender.Name = "PanelRender";
            this.PanelRender.Size = new System.Drawing.Size(1076, 664);
            this.PanelRender.TabIndex = 2;
            this.PanelRender.Leave += new System.EventHandler(this.PanelRender_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel6.Controls.Add(this.LblUserLogged);
            this.panel6.Controls.Add(this.BtnExit);
            this.panel6.Controls.Add(this.BtnMinimize1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(204, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1076, 56);
            this.panel6.TabIndex = 1;
            // 
            // LblUserLogged
            // 
            this.LblUserLogged.AutoSize = true;
            this.LblUserLogged.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUserLogged.ForeColor = System.Drawing.Color.White;
            this.LblUserLogged.Location = new System.Drawing.Point(18, 19);
            this.LblUserLogged.Name = "LblUserLogged";
            this.LblUserLogged.Size = new System.Drawing.Size(97, 19);
            this.LblUserLogged.TabIndex = 6;
            this.LblUserLogged.Text = "Olá, Usuário";
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Aleo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.Transparent;
            this.BtnExit.Location = new System.Drawing.Point(1029, 6);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(35, 28);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "x";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
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
            this.BtnMinimize1.Location = new System.Drawing.Point(987, 12);
            this.BtnMinimize1.Name = "BtnMinimize1";
            this.BtnMinimize1.Size = new System.Drawing.Size(27, 22);
            this.BtnMinimize1.TabIndex = 4;
            this.BtnMinimize1.Text = "-";
            this.BtnMinimize1.UseVisualStyleBackColor = true;
            this.BtnMinimize1.Click += new System.EventHandler(this.BtnMinimize1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.BtnProducts);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 720);
            this.panel2.TabIndex = 0;
            // 
            // BtnProducts
            // 
            this.BtnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProducts.FlatAppearance.BorderSize = 0;
            this.BtnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnProducts.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.Image = global::RestorantiApplication.Properties.Resources.Produtos;
            this.BtnProducts.Location = new System.Drawing.Point(0, 405);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(204, 100);
            this.BtnProducts.TabIndex = 10;
            this.BtnProducts.Text = "Produtos";
            this.BtnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProducts.UseVisualStyleBackColor = false;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.BtnLogout);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 620);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(204, 100);
            this.panel7.TabIndex = 9;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Image = global::RestorantiApplication.Properties.Resources.Exit;
            this.BtnLogout.Location = new System.Drawing.Point(0, 0);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(204, 100);
            this.BtnLogout.TabIndex = 8;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel5.Controls.Add(this.BtnCategorys);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 100);
            this.panel5.TabIndex = 3;
            // 
            // BtnCategorys
            // 
            this.BtnCategorys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnCategorys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCategorys.FlatAppearance.BorderSize = 0;
            this.BtnCategorys.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnCategorys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategorys.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCategorys.ForeColor = System.Drawing.Color.White;
            this.BtnCategorys.Image = ((System.Drawing.Image)(resources.GetObject("BtnCategorys.Image")));
            this.BtnCategorys.Location = new System.Drawing.Point(0, 0);
            this.BtnCategorys.Name = "BtnCategorys";
            this.BtnCategorys.Size = new System.Drawing.Size(204, 100);
            this.BtnCategorys.TabIndex = 1;
            this.BtnCategorys.Text = "Categorias";
            this.BtnCategorys.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCategorys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCategorys.UseVisualStyleBackColor = false;
            this.BtnCategorys.Click += new System.EventHandler(this.BtnCategorys_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel4.Controls.Add(this.BtnUsers);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 100);
            this.panel4.TabIndex = 2;
            // 
            // BtnUsers
            // 
            this.BtnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUsers.ForeColor = System.Drawing.Color.White;
            this.BtnUsers.Image = global::RestorantiApplication.Properties.Resources.usuario;
            this.BtnUsers.Location = new System.Drawing.Point(0, 0);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(204, 100);
            this.BtnUsers.TabIndex = 1;
            this.BtnUsers.Text = "Usuários";
            this.BtnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsers.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 100);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::RestorantiApplication.Properties.Resources.Dashboard;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Indicadores";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pictureBox1.BackgroundImage = global::RestorantiApplication.Properties.Resources.Logo300x2001;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button BtnCategorys;
        private Button BtnUsers;
        private Button button1;
        private Panel panel6;
        private Button BtnMinimize1;
        private Button BtnExit;
        private Label LblUserLogged;
        private Button BtnLogout;
        private Panel panel7;
        private Button BtnProducts;
        private Panel PanelRender;
    }
}