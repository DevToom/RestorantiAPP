namespace RestorantiApplication.Views.Modals
{
    partial class ConfirmModal
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
            this.LblSair = new System.Windows.Forms.Label();
            this.BtnNo = new System.Windows.Forms.Button();
            this.BtnYes = new System.Windows.Forms.Button();
            this.TxtMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.LblSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 39);
            this.panel1.TabIndex = 0;
            // 
            // LblSair
            // 
            this.LblSair.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblSair.AutoSize = true;
            this.LblSair.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSair.ForeColor = System.Drawing.Color.White;
            this.LblSair.Location = new System.Drawing.Point(12, 9);
            this.LblSair.Name = "LblSair";
            this.LblSair.Size = new System.Drawing.Size(83, 19);
            this.LblSair.TabIndex = 1;
            this.LblSair.Text = "Confirmar";
            // 
            // BtnNo
            // 
            this.BtnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNo.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNo.Location = new System.Drawing.Point(276, 163);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(137, 52);
            this.BtnNo.TabIndex = 5;
            this.BtnNo.Text = "NÃO";
            this.BtnNo.UseVisualStyleBackColor = true;
            // 
            // BtnYes
            // 
            this.BtnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYes.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnYes.Location = new System.Drawing.Point(88, 163);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(137, 52);
            this.BtnYes.TabIndex = 4;
            this.BtnYes.Text = "SIM";
            this.BtnYes.UseVisualStyleBackColor = true;
            // 
            // TxtMessage
            // 
            this.TxtMessage.AutoSize = true;
            this.TxtMessage.Font = new System.Drawing.Font("Aleo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtMessage.Location = new System.Drawing.Point(70, 98);
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(368, 25);
            this.TxtMessage.TabIndex = 3;
            this.TxtMessage.Text = "Você deseja confirmar essa operação?";
            // 
            // ConfirmModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmModal";
            this.Load += new System.EventHandler(this.ConfirmModal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label LblSair;
        private Button BtnNo;
        private Button BtnYes;
        private Label TxtMessage;
    }
}