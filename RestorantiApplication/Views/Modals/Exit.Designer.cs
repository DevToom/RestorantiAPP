namespace RestorantiApplication.Views.Modals
{
    partial class Exit
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblSair = new System.Windows.Forms.Label();
            this.BtnNo = new System.Windows.Forms.Button();
            this.BtnYes = new System.Windows.Forms.Button();
            this.BtnMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnNo);
            this.panel1.Controls.Add(this.BtnYes);
            this.panel1.Controls.Add(this.BtnMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 300);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblSair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 39);
            this.panel2.TabIndex = 3;
            // 
            // LblSair
            // 
            this.LblSair.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblSair.AutoSize = true;
            this.LblSair.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblSair.Location = new System.Drawing.Point(12, 9);
            this.LblSair.Name = "LblSair";
            this.LblSair.Size = new System.Drawing.Size(41, 23);
            this.LblSair.TabIndex = 0;
            this.LblSair.Text = "Sair";
            // 
            // BtnNo
            // 
            this.BtnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNo.Location = new System.Drawing.Point(266, 159);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(137, 52);
            this.BtnNo.TabIndex = 2;
            this.BtnNo.Text = "NÃO";
            this.BtnNo.UseVisualStyleBackColor = true;
            // 
            // BtnYes
            // 
            this.BtnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYes.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnYes.Location = new System.Drawing.Point(78, 159);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(137, 52);
            this.BtnYes.TabIndex = 1;
            this.BtnYes.Text = "SIM";
            this.BtnYes.UseVisualStyleBackColor = true;
            // 
            // BtnMessage
            // 
            this.BtnMessage.AutoSize = true;
            this.BtnMessage.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMessage.Location = new System.Drawing.Point(97, 81);
            this.BtnMessage.Name = "BtnMessage";
            this.BtnMessage.Size = new System.Drawing.Size(295, 26);
            this.BtnMessage.TabIndex = 0;
            this.BtnMessage.Text = "Você deseja fechar o aplicativo?";
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button BtnNo;
        private Button BtnYes;
        private Label BtnMessage;
        private Panel panel2;
        private Label LblSair;
    }
}