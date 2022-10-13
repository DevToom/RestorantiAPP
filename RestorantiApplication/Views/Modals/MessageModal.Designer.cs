namespace RestorantiApplication.Views.Modals
{
    partial class MessageModal
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
            this.LblTitleModal = new System.Windows.Forms.Label();
            this.LblSair = new System.Windows.Forms.Label();
            this.BtnNo = new System.Windows.Forms.Button();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LblTitleModal);
            this.panel1.Controls.Add(this.LblSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 39);
            this.panel1.TabIndex = 6;
            // 
            // LblTitleModal
            // 
            this.LblTitleModal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblTitleModal.AutoSize = true;
            this.LblTitleModal.BackColor = System.Drawing.Color.Transparent;
            this.LblTitleModal.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitleModal.ForeColor = System.Drawing.Color.Black;
            this.LblTitleModal.Location = new System.Drawing.Point(12, 9);
            this.LblTitleModal.Name = "LblTitleModal";
            this.LblTitleModal.Size = new System.Drawing.Size(93, 19);
            this.LblTitleModal.TabIndex = 2;
            this.LblTitleModal.Text = "Informação";
            // 
            // LblSair
            // 
            this.LblSair.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblSair.AutoSize = true;
            this.LblSair.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSair.ForeColor = System.Drawing.Color.White;
            this.LblSair.Location = new System.Drawing.Point(12, -22);
            this.LblSair.Name = "LblSair";
            this.LblSair.Size = new System.Drawing.Size(83, 19);
            this.LblSair.TabIndex = 1;
            this.LblSair.Text = "Confirmar";
            // 
            // BtnNo
            // 
            this.BtnNo.BackColor = System.Drawing.Color.White;
            this.BtnNo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNo.Font = new System.Drawing.Font("Aleo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNo.ForeColor = System.Drawing.Color.Black;
            this.BtnNo.Location = new System.Drawing.Point(203, 223);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(91, 30);
            this.BtnNo.TabIndex = 8;
            this.BtnNo.Text = "OK";
            this.BtnNo.UseVisualStyleBackColor = false;
            // 
            // TxtMessage
            // 
            this.TxtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.TxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMessage.Enabled = false;
            this.TxtMessage.Font = new System.Drawing.Font("Aleo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtMessage.ForeColor = System.Drawing.Color.White;
            this.TxtMessage.Location = new System.Drawing.Point(33, 64);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(426, 125);
            this.TxtMessage.TabIndex = 9;
            this.TxtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MessageModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageModal";
            this.Load += new System.EventHandler(this.MessageModal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Label LblSair;
        private Label LblTitleModal;
        private Button BtnNo;
        private TextBox TxtMessage;
    }
}