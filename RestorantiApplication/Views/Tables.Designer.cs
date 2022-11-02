namespace RestorantiApplication.Views
{
    partial class Tables
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LblIdTable = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblIdCategory = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.TxtTableNumber = new System.Windows.Forms.TextBox();
            this.ChkTableStatus = new System.Windows.Forms.ComboBox();
            this.LblTableStatus = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ListTables = new System.Windows.Forms.ListView();
            this.IdHeader = new System.Windows.Forms.ColumnHeader();
            this.NumHeader = new System.Windows.Forms.ColumnHeader();
            this.StatusHeader = new System.Windows.Forms.ColumnHeader();
            this.ListCategorys = new System.Windows.Forms.ListView();
            this.PanelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.PanelHeader.Controls.Add(this.LblIdTable);
            this.PanelHeader.Controls.Add(this.lblFormName);
            this.PanelHeader.Controls.Add(this.lblIdCategory);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1280, 35);
            this.PanelHeader.TabIndex = 2;
            // 
            // LblIdTable
            // 
            this.LblIdTable.AutoSize = true;
            this.LblIdTable.Location = new System.Drawing.Point(156, 9);
            this.LblIdTable.Name = "LblIdTable";
            this.LblIdTable.Size = new System.Drawing.Size(0, 15);
            this.LblIdTable.TabIndex = 2;
            this.LblIdTable.Visible = false;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormName.ForeColor = System.Drawing.Color.White;
            this.lblFormName.Location = new System.Drawing.Point(10, 5);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(63, 23);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Mesas";
            // 
            // lblIdCategory
            // 
            this.lblIdCategory.Location = new System.Drawing.Point(0, 0);
            this.lblIdCategory.Name = "lblIdCategory";
            this.lblIdCategory.Size = new System.Drawing.Size(100, 23);
            this.lblIdCategory.TabIndex = 1;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelBody.Controls.Add(this.TxtTableNumber);
            this.panelBody.Controls.Add(this.ChkTableStatus);
            this.panelBody.Controls.Add(this.LblTableStatus);
            this.panelBody.Controls.Add(this.lblTableNumber);
            this.panelBody.Controls.Add(this.BtnUpdate);
            this.panelBody.Controls.Add(this.BtnRemove);
            this.panelBody.Controls.Add(this.BtnAdd);
            this.panelBody.Controls.Add(this.btnSearch);
            this.panelBody.Controls.Add(this.ListTables);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 35);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1280, 685);
            this.panelBody.TabIndex = 3;
            // 
            // TxtTableNumber
            // 
            this.TxtTableNumber.BackColor = System.Drawing.Color.White;
            this.TxtTableNumber.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTableNumber.Location = new System.Drawing.Point(171, 32);
            this.TxtTableNumber.Name = "TxtTableNumber";
            this.TxtTableNumber.Size = new System.Drawing.Size(96, 30);
            this.TxtTableNumber.TabIndex = 11;
            // 
            // ChkTableStatus
            // 
            this.ChkTableStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChkTableStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkTableStatus.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChkTableStatus.FormattingEnabled = true;
            this.ChkTableStatus.Location = new System.Drawing.Point(171, 100);
            this.ChkTableStatus.Name = "ChkTableStatus";
            this.ChkTableStatus.Size = new System.Drawing.Size(158, 31);
            this.ChkTableStatus.TabIndex = 10;
            // 
            // LblTableStatus
            // 
            this.LblTableStatus.AutoSize = true;
            this.LblTableStatus.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTableStatus.ForeColor = System.Drawing.Color.White;
            this.LblTableStatus.Location = new System.Drawing.Point(12, 103);
            this.LblTableStatus.Name = "LblTableStatus";
            this.LblTableStatus.Size = new System.Drawing.Size(136, 23);
            this.LblTableStatus.TabIndex = 9;
            this.LblTableStatus.Text = "Status da mesa";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTableNumber.ForeColor = System.Drawing.Color.White;
            this.lblTableNumber.Location = new System.Drawing.Point(12, 35);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(153, 23);
            this.lblTableNumber.TabIndex = 8;
            this.lblTableNumber.Text = "Número da mesa";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(366, 219);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(121, 31);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Editar";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.BackColor = System.Drawing.Color.Red;
            this.BtnRemove.FlatAppearance.BorderSize = 0;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Aleo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRemove.ForeColor = System.Drawing.Color.White;
            this.BtnRemove.Location = new System.Drawing.Point(688, 219);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(121, 31);
            this.BtnRemove.TabIndex = 6;
            this.BtnRemove.Text = "Remover";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(525, 219);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(121, 31);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Novo";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Peru;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(12, 219);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ListTables
            // 
            this.ListTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHeader,
            this.NumHeader,
            this.StatusHeader});
            this.ListTables.Font = new System.Drawing.Font("Aleo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListTables.Location = new System.Drawing.Point(854, 15);
            this.ListTables.Name = "ListTables";
            this.ListTables.Size = new System.Drawing.Size(414, 658);
            this.ListTables.TabIndex = 0;
            this.ListTables.UseCompatibleStateImageBehavior = false;
            this.ListTables.View = System.Windows.Forms.View.Details;
            this.ListTables.Click += new System.EventHandler(this.ListTables_Click);
            // 
            // IdHeader
            // 
            this.IdHeader.Text = "Id";
            this.IdHeader.Width = 30;
            // 
            // NumHeader
            // 
            this.NumHeader.Text = "Mesa";
            this.NumHeader.Width = 100;
            // 
            // StatusHeader
            // 
            this.StatusHeader.Text = "Status";
            this.StatusHeader.Width = 200;
            // 
            // ListCategorys
            // 
            this.ListCategorys.Location = new System.Drawing.Point(0, 0);
            this.ListCategorys.Name = "ListCategorys";
            this.ListCategorys.Size = new System.Drawing.Size(121, 97);
            this.ListCategorys.TabIndex = 0;
            this.ListCategorys.UseCompatibleStateImageBehavior = false;
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tables_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelHeader;
        private Label lblFormName;
        private Label lblIdCategory;
        private Panel panelBody;
        private ListView ListCategorys;
        private ListView ListTables;
        private ColumnHeader IdHeader;
        private ColumnHeader StatusHeader;
        private Button BtnUpdate;
        private Button BtnRemove;
        private Button BtnAdd;
        private Button btnSearch;
        private TextBox TxtTableNumber;
        private ComboBox ChkTableStatus;
        private Label LblTableStatus;
        private Label lblTableNumber;
        private ColumnHeader NumHeader;
        private Label LblIdTable;
    }
}