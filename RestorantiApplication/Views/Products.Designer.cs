namespace RestorantiApplication.Views
{
    partial class Products
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
            this.ListProducts = new System.Windows.Forms.ListView();
            this.IdHeader = new System.Windows.Forms.ColumnHeader();
            this.NameHeader = new System.Windows.Forms.ColumnHeader();
            this.CategoryHeader = new System.Windows.Forms.ColumnHeader();
            this.StatusHeader = new System.Windows.Forms.ColumnHeader();
            this.PriceALaCarteHeader = new System.Windows.Forms.ColumnHeader();
            this.PriceRodizioHeader = new System.Windows.Forms.ColumnHeader();
            this.DescriptionHeader = new System.Windows.Forms.ColumnHeader();
            this.ImageHeader = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblDescriptionProd = new System.Windows.Forms.Label();
            this.TxtDescriptionProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPriceRodizio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPriceALaCarte = new System.Windows.Forms.TextBox();
            this.BtnEditProduct = new System.Windows.Forms.Button();
            this.BtnDeleteProduct = new System.Windows.Forms.Button();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.BtnSearchProduct = new System.Windows.Forms.Button();
            this.ChkProductStatus = new System.Windows.Forms.ComboBox();
            this.LblStatusProduct = new System.Windows.Forms.Label();
            this.TxtProdName = new System.Windows.Forms.TextBox();
            this.ChkCategory = new System.Windows.Forms.ComboBox();
            this.LblCatName = new System.Windows.Forms.Label();
            this.LblProductName = new System.Windows.Forms.Label();
            this.BtnSaveImageProd = new System.Windows.Forms.Button();
            this.PanelImageBorder = new System.Windows.Forms.Panel();
            this.PbProduct = new System.Windows.Forms.PictureBox();
            this.BtnUploadImageProd = new System.Windows.Forms.Button();
            this.LblImagemProd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblIdProduct = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelImageBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbProduct)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.ListProducts);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 491);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1280, 229);
            this.panel4.TabIndex = 3;
            // 
            // ListProducts
            // 
            this.ListProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHeader,
            this.NameHeader,
            this.CategoryHeader,
            this.StatusHeader,
            this.PriceALaCarteHeader,
            this.PriceRodizioHeader,
            this.DescriptionHeader,
            this.ImageHeader});
            this.ListProducts.Font = new System.Drawing.Font("Aleo", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListProducts.Location = new System.Drawing.Point(10, 6);
            this.ListProducts.MultiSelect = false;
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(1258, 211);
            this.ListProducts.TabIndex = 0;
            this.ListProducts.UseCompatibleStateImageBehavior = false;
            this.ListProducts.View = System.Windows.Forms.View.Details;
            this.ListProducts.Click += new System.EventHandler(this.ListProducts_Click);
            // 
            // IdHeader
            // 
            this.IdHeader.Text = "Id";
            this.IdHeader.Width = 50;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Nome";
            this.NameHeader.Width = 300;
            // 
            // CategoryHeader
            // 
            this.CategoryHeader.Text = "Tipo de categoria";
            this.CategoryHeader.Width = 300;
            // 
            // StatusHeader
            // 
            this.StatusHeader.Text = "Status";
            this.StatusHeader.Width = 150;
            // 
            // PriceALaCarteHeader
            // 
            this.PriceALaCarteHeader.Text = "Preço À La Carte";
            this.PriceALaCarteHeader.Width = 200;
            // 
            // PriceRodizioHeader
            // 
            this.PriceRodizioHeader.Text = "Preço Rodízio";
            this.PriceRodizioHeader.Width = 200;
            // 
            // DescriptionHeader
            // 
            this.DescriptionHeader.Text = "Descrição do Produto";
            this.DescriptionHeader.Width = 0;
            // 
            // ImageHeader
            // 
            this.ImageHeader.Text = "Imagem";
            this.ImageHeader.Width = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.LblDescriptionProd);
            this.panel3.Controls.Add(this.TxtDescriptionProd);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TxtPriceRodizio);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TxtPriceALaCarte);
            this.panel3.Controls.Add(this.BtnEditProduct);
            this.panel3.Controls.Add(this.BtnDeleteProduct);
            this.panel3.Controls.Add(this.BtnAddProduct);
            this.panel3.Controls.Add(this.BtnSearchProduct);
            this.panel3.Controls.Add(this.ChkProductStatus);
            this.panel3.Controls.Add(this.LblStatusProduct);
            this.panel3.Controls.Add(this.TxtProdName);
            this.panel3.Controls.Add(this.ChkCategory);
            this.panel3.Controls.Add(this.LblCatName);
            this.panel3.Controls.Add(this.LblProductName);
            this.panel3.Controls.Add(this.BtnSaveImageProd);
            this.panel3.Controls.Add(this.PanelImageBorder);
            this.panel3.Controls.Add(this.BtnUploadImageProd);
            this.panel3.Controls.Add(this.LblImagemProd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 456);
            this.panel3.TabIndex = 2;
            // 
            // LblDescriptionProd
            // 
            this.LblDescriptionProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDescriptionProd.AutoSize = true;
            this.LblDescriptionProd.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescriptionProd.ForeColor = System.Drawing.Color.White;
            this.LblDescriptionProd.Location = new System.Drawing.Point(930, 147);
            this.LblDescriptionProd.Name = "LblDescriptionProd";
            this.LblDescriptionProd.Size = new System.Drawing.Size(190, 23);
            this.LblDescriptionProd.TabIndex = 30;
            this.LblDescriptionProd.Text = "Descrição do produto";
            // 
            // TxtDescriptionProd
            // 
            this.TxtDescriptionProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescriptionProd.Location = new System.Drawing.Point(930, 173);
            this.TxtDescriptionProd.Multiline = true;
            this.TxtDescriptionProd.Name = "TxtDescriptionProd";
            this.TxtDescriptionProd.Size = new System.Drawing.Size(291, 141);
            this.TxtDescriptionProd.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(957, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Preço Rodízio";
            // 
            // TxtPriceRodizio
            // 
            this.TxtPriceRodizio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPriceRodizio.BackColor = System.Drawing.Color.White;
            this.TxtPriceRodizio.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPriceRodizio.Location = new System.Drawing.Point(1099, 61);
            this.TxtPriceRodizio.Name = "TxtPriceRodizio";
            this.TxtPriceRodizio.Size = new System.Drawing.Size(122, 30);
            this.TxtPriceRodizio.TabIndex = 27;
            this.TxtPriceRodizio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPriceRodizio_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(930, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Preço À La Carte";
            // 
            // TxtPriceALaCarte
            // 
            this.TxtPriceALaCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPriceALaCarte.BackColor = System.Drawing.Color.White;
            this.TxtPriceALaCarte.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPriceALaCarte.Location = new System.Drawing.Point(1099, 17);
            this.TxtPriceALaCarte.Name = "TxtPriceALaCarte";
            this.TxtPriceALaCarte.Size = new System.Drawing.Size(122, 30);
            this.TxtPriceALaCarte.TabIndex = 25;
            this.TxtPriceALaCarte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPriceALaCarte_KeyPress);
            // 
            // BtnEditProduct
            // 
            this.BtnEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditProduct.BackColor = System.Drawing.Color.IndianRed;
            this.BtnEditProduct.FlatAppearance.BorderSize = 0;
            this.BtnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditProduct.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEditProduct.ForeColor = System.Drawing.Color.White;
            this.BtnEditProduct.Location = new System.Drawing.Point(856, 404);
            this.BtnEditProduct.Name = "BtnEditProduct";
            this.BtnEditProduct.Size = new System.Drawing.Size(121, 31);
            this.BtnEditProduct.TabIndex = 24;
            this.BtnEditProduct.Text = "Editar";
            this.BtnEditProduct.UseVisualStyleBackColor = false;
            this.BtnEditProduct.Click += new System.EventHandler(this.BtnEditProduct_Click);
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.BtnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteProduct.Font = new System.Drawing.Font("Aleo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteProduct.Location = new System.Drawing.Point(1147, 406);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(121, 31);
            this.BtnDeleteProduct.TabIndex = 23;
            this.BtnDeleteProduct.Text = "Remover";
            this.BtnDeleteProduct.UseVisualStyleBackColor = false;
            this.BtnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAddProduct.FlatAppearance.BorderSize = 0;
            this.BtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddProduct.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddProduct.ForeColor = System.Drawing.Color.White;
            this.BtnAddProduct.Location = new System.Drawing.Point(1003, 404);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(121, 31);
            this.BtnAddProduct.TabIndex = 22;
            this.BtnAddProduct.Text = "Novo";
            this.BtnAddProduct.UseVisualStyleBackColor = false;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnSearchProduct
            // 
            this.BtnSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSearchProduct.BackColor = System.Drawing.Color.Peru;
            this.BtnSearchProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSearchProduct.FlatAppearance.BorderSize = 0;
            this.BtnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchProduct.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.BtnSearchProduct.Location = new System.Drawing.Point(12, 404);
            this.BtnSearchProduct.Name = "BtnSearchProduct";
            this.BtnSearchProduct.Size = new System.Drawing.Size(121, 31);
            this.BtnSearchProduct.TabIndex = 21;
            this.BtnSearchProduct.Text = "Pesquisar";
            this.BtnSearchProduct.UseVisualStyleBackColor = false;
            this.BtnSearchProduct.Click += new System.EventHandler(this.BtnSearchProduct_Click);
            // 
            // ChkProductStatus
            // 
            this.ChkProductStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkProductStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkProductStatus.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChkProductStatus.FormattingEnabled = true;
            this.ChkProductStatus.Location = new System.Drawing.Point(723, 16);
            this.ChkProductStatus.Name = "ChkProductStatus";
            this.ChkProductStatus.Size = new System.Drawing.Size(175, 31);
            this.ChkProductStatus.TabIndex = 20;
            // 
            // LblStatusProduct
            // 
            this.LblStatusProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblStatusProduct.AutoSize = true;
            this.LblStatusProduct.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStatusProduct.ForeColor = System.Drawing.Color.White;
            this.LblStatusProduct.Location = new System.Drawing.Point(654, 16);
            this.LblStatusProduct.Name = "LblStatusProduct";
            this.LblStatusProduct.Size = new System.Drawing.Size(63, 23);
            this.LblStatusProduct.TabIndex = 19;
            this.LblStatusProduct.Text = "Status";
            // 
            // TxtProdName
            // 
            this.TxtProdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtProdName.BackColor = System.Drawing.Color.White;
            this.TxtProdName.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtProdName.Location = new System.Drawing.Point(74, 16);
            this.TxtProdName.Name = "TxtProdName";
            this.TxtProdName.Size = new System.Drawing.Size(314, 30);
            this.TxtProdName.TabIndex = 18;
            // 
            // ChkCategory
            // 
            this.ChkCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChkCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkCategory.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChkCategory.FormattingEnabled = true;
            this.ChkCategory.ItemHeight = 23;
            this.ChkCategory.Location = new System.Drawing.Point(490, 16);
            this.ChkCategory.Name = "ChkCategory";
            this.ChkCategory.Size = new System.Drawing.Size(158, 31);
            this.ChkCategory.TabIndex = 17;
            // 
            // LblCatName
            // 
            this.LblCatName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCatName.AutoSize = true;
            this.LblCatName.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCatName.ForeColor = System.Drawing.Color.White;
            this.LblCatName.Location = new System.Drawing.Point(394, 16);
            this.LblCatName.Name = "LblCatName";
            this.LblCatName.Size = new System.Drawing.Size(90, 23);
            this.LblCatName.TabIndex = 16;
            this.LblCatName.Text = "Categoria";
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblProductName.ForeColor = System.Drawing.Color.White;
            this.LblProductName.Location = new System.Drawing.Point(12, 16);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(61, 23);
            this.LblProductName.TabIndex = 15;
            this.LblProductName.Text = "Nome";
            // 
            // BtnSaveImageProd
            // 
            this.BtnSaveImageProd.Font = new System.Drawing.Font("Aleo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSaveImageProd.Location = new System.Drawing.Point(328, 375);
            this.BtnSaveImageProd.Name = "BtnSaveImageProd";
            this.BtnSaveImageProd.Size = new System.Drawing.Size(108, 23);
            this.BtnSaveImageProd.TabIndex = 14;
            this.BtnSaveImageProd.Text = "Salvar imagem";
            this.BtnSaveImageProd.UseVisualStyleBackColor = true;
            this.BtnSaveImageProd.Click += new System.EventHandler(this.BtnSaveImageProd_Click);
            // 
            // PanelImageBorder
            // 
            this.PanelImageBorder.BackColor = System.Drawing.Color.White;
            this.PanelImageBorder.Controls.Add(this.PbProduct);
            this.PanelImageBorder.Location = new System.Drawing.Point(12, 88);
            this.PanelImageBorder.Name = "PanelImageBorder";
            this.PanelImageBorder.Size = new System.Drawing.Size(310, 310);
            this.PanelImageBorder.TabIndex = 13;
            // 
            // PbProduct
            // 
            this.PbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.PbProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbProduct.Location = new System.Drawing.Point(5, 5);
            this.PbProduct.Name = "PbProduct";
            this.PbProduct.Size = new System.Drawing.Size(300, 300);
            this.PbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbProduct.TabIndex = 11;
            this.PbProduct.TabStop = false;
            // 
            // BtnUploadImageProd
            // 
            this.BtnUploadImageProd.Font = new System.Drawing.Font("Aleo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUploadImageProd.Location = new System.Drawing.Point(92, 61);
            this.BtnUploadImageProd.Name = "BtnUploadImageProd";
            this.BtnUploadImageProd.Size = new System.Drawing.Size(129, 23);
            this.BtnUploadImageProd.TabIndex = 12;
            this.BtnUploadImageProd.Text = "Carregar Imagem ...";
            this.BtnUploadImageProd.UseVisualStyleBackColor = true;
            this.BtnUploadImageProd.Click += new System.EventHandler(this.BtnUploadImageProd_Click);
            // 
            // LblImagemProd
            // 
            this.LblImagemProd.AutoSize = true;
            this.LblImagemProd.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblImagemProd.ForeColor = System.Drawing.Color.White;
            this.LblImagemProd.Location = new System.Drawing.Point(10, 61);
            this.LblImagemProd.Name = "LblImagemProd";
            this.LblImagemProd.Size = new System.Drawing.Size(66, 19);
            this.LblImagemProd.TabIndex = 10;
            this.LblImagemProd.Text = "Imagem";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2058, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1743, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Cardápio";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.LblIdProduct);
            this.panel2.Controls.Add(this.lblFormName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 35);
            this.panel2.TabIndex = 1;
            // 
            // LblIdProduct
            // 
            this.LblIdProduct.AutoSize = true;
            this.LblIdProduct.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdProduct.ForeColor = System.Drawing.Color.White;
            this.LblIdProduct.Location = new System.Drawing.Point(597, 6);
            this.LblIdProduct.Name = "LblIdProduct";
            this.LblIdProduct.Size = new System.Drawing.Size(0, 23);
            this.LblIdProduct.TabIndex = 11;
            this.LblIdProduct.Visible = false;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormName.ForeColor = System.Drawing.Color.White;
            this.lblFormName.Location = new System.Drawing.Point(10, 5);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(87, 23);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Produtos";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelImageBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private ListView ListProducts;
        private ColumnHeader IdHeader;
        private ColumnHeader NameHeader;
        private ColumnHeader CategoryHeader;
        private ColumnHeader StatusHeader;
        private ColumnHeader ImageHeader;
        private Panel panel3;
        private Button BtnSaveImageProd;
        private Panel PanelImageBorder;
        private PictureBox PbProduct;
        private Button BtnUploadImageProd;
        private Label LblImagemProd;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label lblFormName;
        private ComboBox ChkProductStatus;
        private Label LblStatusProduct;
        private TextBox TxtProdName;
        private ComboBox ChkCategory;
        private Label LblCatName;
        private Label LblProductName;
        private Button BtnEditProduct;
        private Button BtnDeleteProduct;
        private Button BtnAddProduct;
        private Button BtnSearchProduct;
        private ColumnHeader PriceALaCarteHeader;
        private ColumnHeader PriceRodizioHeader;
        private TextBox TxtPriceALaCarte;
        private Label label4;
        private TextBox TxtPriceRodizio;
        private Label label1;
        private Label LblIdProduct;
        private TextBox TxtDescriptionProd;
        private Label LblDescriptionProd;
        private ColumnHeader DescriptionHeader;
    }
}