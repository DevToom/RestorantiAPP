namespace RestorantiApplication.Views
{
    partial class Categorys
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.ListCategorys = new System.Windows.Forms.ListView();
            this.IdHeader = new System.Windows.Forms.ColumnHeader();
            this.NameHeader = new System.Windows.Forms.ColumnHeader();
            this.MenuTypeHeader = new System.Windows.Forms.ColumnHeader();
            this.StatusHeader = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnUploadImageCat = new System.Windows.Forms.Button();
            this.PbCategory = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCatName = new System.Windows.Forms.TextBox();
            this.ChkMenuType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblIdCategory = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCategory)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.ListCategorys);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 596);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1280, 124);
            this.panel4.TabIndex = 3;
            // 
            // ListCategorys
            // 
            this.ListCategorys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListCategorys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHeader,
            this.NameHeader,
            this.MenuTypeHeader,
            this.StatusHeader});
            this.ListCategorys.Location = new System.Drawing.Point(10, 6);
            this.ListCategorys.MultiSelect = false;
            this.ListCategorys.Name = "ListCategorys";
            this.ListCategorys.Size = new System.Drawing.Size(1258, 106);
            this.ListCategorys.TabIndex = 0;
            this.ListCategorys.UseCompatibleStateImageBehavior = false;
            this.ListCategorys.View = System.Windows.Forms.View.Details;
            this.ListCategorys.Click += new System.EventHandler(this.ListCategorys_Click);
            // 
            // IdHeader
            // 
            this.IdHeader.Text = "Id";
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Nome";
            this.NameHeader.Width = 350;
            // 
            // MenuTypeHeader
            // 
            this.MenuTypeHeader.Text = "Tipo de cardápio";
            this.MenuTypeHeader.Width = 200;
            // 
            // StatusHeader
            // 
            this.StatusHeader.Text = "Status";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.BtnUploadImageCat);
            this.panel3.Controls.Add(this.PbCategory);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ChkStatus);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtCatName);
            this.panel3.Controls.Add(this.ChkMenuType);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.BtnUpdate);
            this.panel3.Controls.Add(this.BtnRemove);
            this.panel3.Controls.Add(this.BtnAdd);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 561);
            this.panel3.TabIndex = 2;
            // 
            // BtnUploadImageCat
            // 
            this.BtnUploadImageCat.Font = new System.Drawing.Font("Aleo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUploadImageCat.Location = new System.Drawing.Point(94, 93);
            this.BtnUploadImageCat.Name = "BtnUploadImageCat";
            this.BtnUploadImageCat.Size = new System.Drawing.Size(129, 23);
            this.BtnUploadImageCat.TabIndex = 12;
            this.BtnUploadImageCat.Text = "Carregar Imagem ...";
            this.BtnUploadImageCat.UseVisualStyleBackColor = true;
            this.BtnUploadImageCat.Click += new System.EventHandler(this.BtnUploadImageCat_Click);
            // 
            // PbCategory
            // 
            this.PbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.PbCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbCategory.Location = new System.Drawing.Point(12, 122);
            this.PbCategory.Name = "PbCategory";
            this.PbCategory.Size = new System.Drawing.Size(350, 350);
            this.PbCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCategory.TabIndex = 11;
            this.PbCategory.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Imagem";
            // 
            // ChkStatus
            // 
            this.ChkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkStatus.Font = new System.Drawing.Font("Aleo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChkStatus.FormattingEnabled = true;
            this.ChkStatus.Items.AddRange(new object[] {
            "Selecione...",
            "Ativo",
            "Inativo"});
            this.ChkStatus.Location = new System.Drawing.Point(1040, 21);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Size = new System.Drawing.Size(175, 24);
            this.ChkStatus.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(980, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status";
            // 
            // TxtCatName
            // 
            this.TxtCatName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCatName.BackColor = System.Drawing.Color.White;
            this.TxtCatName.Font = new System.Drawing.Font("Aleo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCatName.Location = new System.Drawing.Point(65, 19);
            this.TxtCatName.Name = "TxtCatName";
            this.TxtCatName.Size = new System.Drawing.Size(592, 23);
            this.TxtCatName.TabIndex = 7;
            // 
            // ChkMenuType
            // 
            this.ChkMenuType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkMenuType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkMenuType.Font = new System.Drawing.Font("Aleo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChkMenuType.FormattingEnabled = true;
            this.ChkMenuType.Items.AddRange(new object[] {
            "Selecione...",
            "À La Carte",
            "Rodízio"});
            this.ChkMenuType.Location = new System.Drawing.Point(814, 19);
            this.ChkMenuType.Name = "ChkMenuType";
            this.ChkMenuType.Size = new System.Drawing.Size(158, 24);
            this.ChkMenuType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(680, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Cardápio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(856, 509);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(121, 31);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Editar";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.BackColor = System.Drawing.Color.Red;
            this.BtnRemove.FlatAppearance.BorderSize = 0;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Aleo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRemove.ForeColor = System.Drawing.Color.White;
            this.BtnRemove.Location = new System.Drawing.Point(1147, 511);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(121, 31);
            this.BtnRemove.TabIndex = 2;
            this.BtnRemove.Text = "Remover";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(1003, 509);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(121, 31);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.BackColor = System.Drawing.Color.Peru;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(12, 509);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 31);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.lblFormName);
            this.panel2.Controls.Add(this.lblIdCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 35);
            this.panel2.TabIndex = 1;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormName.ForeColor = System.Drawing.Color.White;
            this.lblFormName.Location = new System.Drawing.Point(10, 5);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(98, 23);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Categorias";
            // 
            // lblIdCategory
            // 
            this.lblIdCategory.AutoSize = true;
            this.lblIdCategory.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblIdCategory.Location = new System.Drawing.Point(114, 9);
            this.lblIdCategory.Name = "lblIdCategory";
            this.lblIdCategory.Size = new System.Drawing.Size(0, 19);
            this.lblIdCategory.TabIndex = 10;
            // 
            // Categorys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categorys";
            this.Text = "Categorys";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Categorys_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCategory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblFormName;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Button BtnUpdate;
        private Button BtnRemove;
        private Button BtnAdd;
        private Button btnSearch;
        private Panel panel2;
        private TextBox TxtCatName;
        private ComboBox ChkMenuType;
        private Label label2;
        private ListView ListCategorys;
        private ColumnHeader IdHeader;
        private ColumnHeader NameHeader;
        private ColumnHeader StatusHeader;
        private ComboBox ChkStatus;
        private Label label3;
        private Label lblIdCategory;
        private ColumnHeader MenuTypeHeader;
        private Label label4;
        private PictureBox PbCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button BtnUploadImageCat;
    }
}