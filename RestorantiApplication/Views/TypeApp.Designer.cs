namespace RestorantiApplication.Views
{
    partial class TypeApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKitchen = new System.Windows.Forms.Button();
            this.BtnCashier = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.BtnMinimize);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 56);
            this.panel1.TabIndex = 0;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.BackgroundImage = global::RestorantiApplication.Properties.Resources.minimize61;
            this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Aleo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.Location = new System.Drawing.Point(1167, 18);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(27, 22);
            this.BtnMinimize.TabIndex = 1;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Aleo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.Transparent;
            this.BtnExit.Location = new System.Drawing.Point(1220, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(35, 28);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "x";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnKitchen);
            this.panel2.Controls.Add(this.BtnCashier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 664);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aleo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ESCOLHA O AMBIENTE DE ACESSO";
            // 
            // BtnKitchen
            // 
            this.BtnKitchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnKitchen.BackgroundImage = global::RestorantiApplication.Properties.Resources.Cozinha1;
            this.BtnKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnKitchen.FlatAppearance.BorderSize = 0;
            this.BtnKitchen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKitchen.Font = new System.Drawing.Font("Aleo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnKitchen.ForeColor = System.Drawing.Color.White;
            this.BtnKitchen.Location = new System.Drawing.Point(659, 196);
            this.BtnKitchen.Name = "BtnKitchen";
            this.BtnKitchen.Size = new System.Drawing.Size(303, 216);
            this.BtnKitchen.TabIndex = 1;
            this.BtnKitchen.Text = "COZINHA";
            this.BtnKitchen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnKitchen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnKitchen.UseVisualStyleBackColor = true;
            this.BtnKitchen.Click += new System.EventHandler(this.BtnKitchen_Click);
            // 
            // BtnCashier
            // 
            this.BtnCashier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCashier.BackgroundImage = global::RestorantiApplication.Properties.Resources.Caixa1;
            this.BtnCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCashier.FlatAppearance.BorderSize = 0;
            this.BtnCashier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCashier.Font = new System.Drawing.Font("Aleo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCashier.ForeColor = System.Drawing.Color.White;
            this.BtnCashier.Location = new System.Drawing.Point(273, 196);
            this.BtnCashier.Name = "BtnCashier";
            this.BtnCashier.Size = new System.Drawing.Size(296, 216);
            this.BtnCashier.TabIndex = 0;
            this.BtnCashier.Text = "CAIXA";
            this.BtnCashier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCashier.UseVisualStyleBackColor = true;
            this.BtnCashier.Click += new System.EventHandler(this.BtnCashier_Click);
            // 
            // TypeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TypeApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypeApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button BtnMinimize;
        private Button BtnExit;
        private Panel panel2;
        private Button BtnCashier;
        private Label label1;
        private Button BtnKitchen;
    }
}