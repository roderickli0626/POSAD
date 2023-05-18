namespace POSAD
{
    partial class frmStockIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockIn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            btnEntry = new System.Windows.Forms.Button();
            dgvStockIn = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Delete = new System.Windows.Forms.DataGridViewImageColumn();
            panel2 = new System.Windows.Forms.Panel();
            txtAddress = new System.Windows.Forms.TextBox();
            txtConPerson = new System.Windows.Forms.TextBox();
            cbSupplier = new System.Windows.Forms.ComboBox();
            LinProduct = new System.Windows.Forms.LinkLabel();
            LinGenerate = new System.Windows.Forms.LinkLabel();
            dtStockIn = new System.Windows.Forms.DateTimePicker();
            txtStockInBy = new System.Windows.Forms.TextBox();
            txtRefNo = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblId = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            dgvInStockHistory = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel3 = new System.Windows.Forms.Panel();
            btnLoad = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            dtTo = new System.Windows.Forms.DateTimePicker();
            dtFrom = new System.Windows.Forms.DateTimePicker();
            label8 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvStockIn)).BeginInit();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvInStockHistory)).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            tabControl1.Location = new System.Drawing.Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(999, 497);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEntry);
            tabPage1.Controls.Add(dgvStockIn);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(991, 464);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Stock In";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEntry
            // 
            btnEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            btnEntry.FlatAppearance.BorderSize = 0;
            btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEntry.ForeColor = System.Drawing.Color.White;
            btnEntry.Location = new System.Drawing.Point(891, 423);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new System.Drawing.Size(94, 35);
            btnEntry.TabIndex = 13;
            btnEntry.Text = "Entry";
            btnEntry.UseVisualStyleBackColor = false;
            btnEntry.Click += new System.EventHandler(btnEntry_Click);
            // 
            // dgvStockIn
            // 
            dgvStockIn.AllowUserToAddRows = false;
            dgvStockIn.BackgroundColor = System.Drawing.Color.White;
            dgvStockIn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStockIn.ColumnHeadersHeight = 30;
            dgvStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStockIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Column1,
            Column9,
            Column10,
            Column2,
            Column4,
            Column5,
            Column6,
            Column7,
            Column8,
            Delete});
            dgvStockIn.Dock = System.Windows.Forms.DockStyle.Top;
            dgvStockIn.EnableHeadersVisualStyles = false;
            dgvStockIn.Location = new System.Drawing.Point(3, 161);
            dgvStockIn.Name = "dgvStockIn";
            dgvStockIn.RowHeadersVisible = false;
            dgvStockIn.Size = new System.Drawing.Size(985, 256);
            dgvStockIn.TabIndex = 6;
            dgvStockIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvStockIn_CellContentClick);
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.Name = "Column1";
            Column1.Width = 53;
            // 
            // Column9
            // 
            Column9.HeaderText = "Id";
            Column9.Name = "Column9";
            Column9.Visible = false;
            // 
            // Column10
            // 
            Column10.HeaderText = "Reference#";
            Column10.Name = "Column10";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Pcode";
            Column2.Name = "Column2";
            Column2.Width = 81;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Description";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Qty";
            Column5.Name = "Column5";
            Column5.Width = 58;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Stock In Date";
            Column6.Name = "Column6";
            Column6.Width = 130;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Stock In By";
            Column7.Name = "Column7";
            Column7.Width = 111;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Supplier";
            Column8.Name = "Column8";
            Column8.Width = 89;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            Delete.Name = "Delete";
            Delete.Width = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtConPerson);
            panel2.Controls.Add(cbSupplier);
            panel2.Controls.Add(LinProduct);
            panel2.Controls.Add(LinGenerate);
            panel2.Controls.Add(dtStockIn);
            panel2.Controls.Add(txtStockInBy);
            panel2.Controls.Add(txtRefNo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblId);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(985, 158);
            panel2.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            txtAddress.Location = new System.Drawing.Point(617, 92);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(351, 26);
            txtAddress.TabIndex = 7;
            // 
            // txtConPerson
            // 
            txtConPerson.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            txtConPerson.Location = new System.Drawing.Point(617, 52);
            txtConPerson.Name = "txtConPerson";
            txtConPerson.Size = new System.Drawing.Size(351, 26);
            txtConPerson.TabIndex = 6;
            // 
            // cbSupplier
            // 
            cbSupplier.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new System.Drawing.Point(617, 11);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new System.Drawing.Size(351, 28);
            cbSupplier.TabIndex = 5;
            cbSupplier.TextChanged += new System.EventHandler(cbSupplier_TextChanged);
            cbSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(cbSupplier_KeyPress);
            // 
            // LinProduct
            // 
            LinProduct.AutoSize = true;
            LinProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            LinProduct.LinkColor = System.Drawing.Color.DimGray;
            LinProduct.Location = new System.Drawing.Point(139, 127);
            LinProduct.Name = "LinProduct";
            LinProduct.Size = new System.Drawing.Size(242, 20);
            LinProduct.TabIndex = 4;
            LinProduct.TabStop = true;
            LinProduct.Text = "[ Click here to browse product ]";
            LinProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(LinProduct_LinkClicked);
            // 
            // LinGenerate
            // 
            LinGenerate.AutoSize = true;
            LinGenerate.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            LinGenerate.LinkColor = System.Drawing.Color.DimGray;
            LinGenerate.Location = new System.Drawing.Point(322, 15);
            LinGenerate.Name = "LinGenerate";
            LinGenerate.Size = new System.Drawing.Size(99, 20);
            LinGenerate.TabIndex = 4;
            LinGenerate.TabStop = true;
            LinGenerate.Text = "[ Generate ]";
            LinGenerate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(LinGenerate_LinkClicked);
            // 
            // dtStockIn
            // 
            dtStockIn.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dtStockIn.Location = new System.Drawing.Point(143, 90);
            dtStockIn.Name = "dtStockIn";
            dtStockIn.Size = new System.Drawing.Size(278, 26);
            dtStockIn.TabIndex = 3;
            // 
            // txtStockInBy
            // 
            txtStockInBy.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            txtStockInBy.Location = new System.Drawing.Point(143, 52);
            txtStockInBy.Name = "txtStockInBy";
            txtStockInBy.Size = new System.Drawing.Size(278, 26);
            txtStockInBy.TabIndex = 2;
            // 
            // txtRefNo
            // 
            txtRefNo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            txtRefNo.Location = new System.Drawing.Point(143, 11);
            txtRefNo.Name = "txtRefNo";
            txtRefNo.Size = new System.Drawing.Size(165, 26);
            txtRefNo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label4.Location = new System.Drawing.Point(8, 90);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(115, 20);
            label4.TabIndex = 0;
            label4.Text = "Stock In Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label3.Location = new System.Drawing.Point(8, 52);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 20);
            label3.TabIndex = 0;
            label3.Text = "Stock In By :";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(463, 127);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(37, 20);
            lblId.TabIndex = 0;
            lblId.Text = "lbId";
            lblId.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label7.Location = new System.Drawing.Point(463, 90);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(75, 20);
            label7.TabIndex = 0;
            label7.Text = "Address :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label6.Location = new System.Drawing.Point(463, 52);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(134, 20);
            label6.TabIndex = 0;
            label6.Text = "Contack Person :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label5.Location = new System.Drawing.Point(463, 17);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(74, 20);
            label5.TabIndex = 0;
            label5.Text = "Supplier :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label2.Location = new System.Drawing.Point(8, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 20);
            label2.TabIndex = 0;
            label2.Text = "Reference No :";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvInStockHistory);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(991, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Stock In Record";
            // 
            // dgvInStockHistory
            // 
            dgvInStockHistory.AllowUserToAddRows = false;
            dgvInStockHistory.BackgroundColor = System.Drawing.Color.White;
            dgvInStockHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvInStockHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInStockHistory.ColumnHeadersHeight = 30;
            dgvInStockHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInStockHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewTextBoxColumn1,
            dataGridViewTextBoxColumn2,
            dataGridViewTextBoxColumn3,
            dataGridViewTextBoxColumn4,
            dataGridViewTextBoxColumn5,
            dataGridViewTextBoxColumn6,
            dataGridViewTextBoxColumn7,
            dataGridViewTextBoxColumn8,
            dataGridViewTextBoxColumn9});
            dgvInStockHistory.Dock = System.Windows.Forms.DockStyle.Top;
            dgvInStockHistory.EnableHeadersVisualStyles = false;
            dgvInStockHistory.Location = new System.Drawing.Point(3, 75);
            dgvInStockHistory.Name = "dgvInStockHistory";
            dgvInStockHistory.RowHeadersVisible = false;
            dgvInStockHistory.Size = new System.Drawing.Size(985, 387);
            dgvInStockHistory.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "No";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 53;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Id";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Reference#";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.HeaderText = "Pcode";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 81;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Description";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.HeaderText = "Qty";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 58;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn7.HeaderText = "Stock In Date";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn8.HeaderText = "Stock In By";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 111;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn9.HeaderText = "Supplier";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 89;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLoad);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(dtTo);
            panel3.Controls.Add(dtFrom);
            panel3.Controls.Add(label8);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(985, 72);
            panel3.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoad.ForeColor = System.Drawing.Color.White;
            btnLoad.Location = new System.Drawing.Point(494, 17);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(115, 29);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load Record";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += new System.EventHandler(btnLoad_Click);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(295, 25);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(24, 20);
            label9.TabIndex = 2;
            label9.Text = "To";
            // 
            // dtTo
            // 
            dtTo.CustomFormat = "dd/MM/yyyy";
            dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtTo.Location = new System.Drawing.Point(334, 19);
            dtTo.Name = "dtTo";
            dtTo.Size = new System.Drawing.Size(116, 26);
            dtTo.TabIndex = 1;
            // 
            // dtFrom
            // 
            dtFrom.CustomFormat = "dd/MM/yyyy";
            dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtFrom.Location = new System.Drawing.Point(164, 20);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new System.Drawing.Size(116, 26);
            dtFrom.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(8, 25);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(150, 20);
            label8.TabIndex = 0;
            label8.Text = "Filter By Date : From";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 514);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1015, 67);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.Location = new System.Drawing.Point(7, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 43);
            label1.TabIndex = 0;
            label1.Text = "Stock In Module";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmStockIn
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1015, 581);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Name = "frmStockIn";
            Text = "frmStockIn";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dgvStockIn)).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dgvInStockHistory)).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.DataGridView dgvStockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtConPerson;
        public System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.LinkLabel LinProduct;
        private System.Windows.Forms.LinkLabel LinGenerate;
        public System.Windows.Forms.DateTimePicker dtStockIn;
        public System.Windows.Forms.TextBox txtStockInBy;
        public System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvInStockHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}