namespace RestorantiApplication.Views
{
    partial class Kitchen
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
            this.flowPrepare = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowPreparing = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPrepared = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMinimize1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPrepare
            // 
            this.flowPrepare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowPrepare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowPrepare.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPrepare.Location = new System.Drawing.Point(12, 148);
            this.flowPrepare.Name = "flowPrepare";
            this.flowPrepare.Size = new System.Drawing.Size(370, 569);
            this.flowPrepare.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aleo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "A PREPARAR";
            // 
            // flowPreparing
            // 
            this.flowPreparing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowPreparing.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPreparing.Location = new System.Drawing.Point(447, 148);
            this.flowPreparing.Name = "flowPreparing";
            this.flowPreparing.Size = new System.Drawing.Size(370, 569);
            this.flowPreparing.TabIndex = 1;
            // 
            // flowPrepared
            // 
            this.flowPrepared.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowPrepared.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPrepared.Location = new System.Drawing.Point(898, 148);
            this.flowPrepared.Name = "flowPrepared";
            this.flowPrepared.Size = new System.Drawing.Size(370, 569);
            this.flowPrepared.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aleo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(543, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "PREPARANDO";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aleo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1002, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "PREPARADO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.flowPrepare);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowPrepared);
            this.panel1.Controls.Add(this.flowPreparing);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel6.Controls.Add(this.BtnLogout);
            this.panel6.Controls.Add(this.BtnExit);
            this.panel6.Controls.Add(this.BtnMinimize);
            this.panel6.Controls.Add(this.BtnMinimize1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1280, 56);
            this.panel6.TabIndex = 4;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Image = global::RestorantiApplication.Properties.Resources.Exit;
            this.BtnLogout.Location = new System.Drawing.Point(24, 6);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(33, 38);
            this.BtnLogout.TabIndex = 9;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Aleo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.Transparent;
            this.BtnExit.Location = new System.Drawing.Point(1233, 6);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(35, 28);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "x";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.BackgroundImage = global::RestorantiApplication.Properties.Resources.minimize61;
            this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.Location = new System.Drawing.Point(1191, 12);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(27, 22);
            this.BtnMinimize.TabIndex = 7;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
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
            this.BtnMinimize1.Location = new System.Drawing.Point(2067, -10);
            this.BtnMinimize1.Name = "BtnMinimize1";
            this.BtnMinimize1.Size = new System.Drawing.Size(27, 22);
            this.BtnMinimize1.TabIndex = 4;
            this.BtnMinimize1.Text = "-";
            this.BtnMinimize1.UseVisualStyleBackColor = true;
            // 
            // Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kitchen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitchen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Kitchen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowPrepare;
        private Label label1;
        private FlowLayoutPanel flowPreparing;
        private FlowLayoutPanel flowPrepared;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel6;
        private Button BtnMinimize1;
        private Button BtnMinimize;
        private Button BtnExit;
        private Button BtnLogout;
    }
}