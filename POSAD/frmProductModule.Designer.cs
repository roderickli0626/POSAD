namespace POSAD
{
    partial class frmProductModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductModule));
            label10 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            checkShopware = new System.Windows.Forms.CheckBox();
            label9 = new System.Windows.Forms.Label();
            resultPictureBox = new System.Windows.Forms.PictureBox();
            lblQr = new System.Windows.Forms.Label();
            UDReOrder = new System.Windows.Forms.NumericUpDown();
            txtPrice = new System.Windows.Forms.TextBox();
            cboCategory = new System.Windows.Forms.ComboBox();
            cboBrand = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtPdesc = new System.Windows.Forms.TextBox();
            txtBarcode = new System.Windows.Forms.TextBox();
            txtPcode = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            picClose = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(UDReOrder)).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picClose)).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label10.Location = new System.Drawing.Point(256, 343);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(174, 20);
            label10.TabIndex = 47;
            label10.Text = "Description Shopware:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(259, 374);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(442, 87);
            textBox1.TabIndex = 46;
            // 
            // checkShopware
            // 
            checkShopware.AutoSize = true;
            checkShopware.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            checkShopware.Location = new System.Drawing.Point(507, 316);
            checkShopware.Name = "checkShopware";
            checkShopware.Size = new System.Drawing.Size(203, 24);
            checkShopware.TabIndex = 45;
            checkShopware.Text = "Update Shopware Data";
            checkShopware.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label9.Location = new System.Drawing.Point(29, 320);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(77, 20);
            label9.TabIndex = 44;
            label9.Tag = "resultPictureBox";
            label9.Text = "Qr Code:";
            // 
            // resultPictureBox
            // 
            resultPictureBox.Location = new System.Drawing.Point(33, 343);
            resultPictureBox.Name = "resultPictureBox";
            resultPictureBox.Size = new System.Drawing.Size(184, 166);
            resultPictureBox.TabIndex = 43;
            resultPictureBox.TabStop = false;
            // 
            // lblQr
            // 
            lblQr.AutoSize = true;
            lblQr.Location = new System.Drawing.Point(748, 192);
            lblQr.Name = "lblQr";
            lblQr.Size = new System.Drawing.Size(0, 13);
            lblQr.TabIndex = 42;
            // 
            // UDReOrder
            // 
            UDReOrder.Location = new System.Drawing.Point(507, 270);
            UDReOrder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            UDReOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            UDReOrder.Name = "UDReOrder";
            UDReOrder.Size = new System.Drawing.Size(184, 20);
            UDReOrder.TabIndex = 41;
            UDReOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            UDReOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(160, 270);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(194, 20);
            txtPrice.TabIndex = 40;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new System.Drawing.Point(160, 224);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new System.Drawing.Size(531, 21);
            cboCategory.TabIndex = 38;
            // 
            // cboBrand
            // 
            cboBrand.FormattingEnabled = true;
            cboBrand.Location = new System.Drawing.Point(160, 178);
            cboBrand.Name = "cboBrand";
            cboBrand.Size = new System.Drawing.Size(531, 21);
            cboBrand.TabIndex = 39;
            // 
            // btnSave
            // 
            btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(417, 488);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 35);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += new System.EventHandler(btnSave_Click);
            // 
            // btnCancel
            // 
            btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.ForeColor = System.Drawing.Color.Black;
            btnCancel.Location = new System.Drawing.Point(617, 488);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 35);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(517, 488);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 35);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += new System.EventHandler(btnUpdate_Click);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label8.Location = new System.Drawing.Point(373, 273);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(128, 20);
            label8.TabIndex = 34;
            label8.Text = "Re-Order Level :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label6.Location = new System.Drawing.Point(29, 228);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(87, 20);
            label6.TabIndex = 33;
            label6.Text = "Category :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label4.Location = new System.Drawing.Point(29, 137);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 20);
            label4.TabIndex = 32;
            label4.Text = "Title :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label3.Location = new System.Drawing.Point(387, 93);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 20);
            label3.TabIndex = 31;
            label3.Tag = "resultPictureBox";
            label3.Text = "Qr Code Text:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label2.Location = new System.Drawing.Point(29, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 20);
            label2.TabIndex = 30;
            label2.Text = "Product Code :";
            // 
            // txtPdesc
            // 
            txtPdesc.Location = new System.Drawing.Point(160, 134);
            txtPdesc.Name = "txtPdesc";
            txtPdesc.Size = new System.Drawing.Size(531, 20);
            txtPdesc.TabIndex = 27;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new System.Drawing.Point(507, 90);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new System.Drawing.Size(184, 20);
            txtBarcode.TabIndex = 26;
            txtBarcode.TextChanged += new System.EventHandler(txtBarcode_TextChanged);
            // 
            // txtPcode
            // 
            txtPcode.Location = new System.Drawing.Point(160, 90);
            txtPcode.Name = "txtPcode";
            txtPcode.Size = new System.Drawing.Size(194, 20);
            txtPcode.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(738, 50);
            panel1.TabIndex = 24;
            // 
            // picClose
            // 
            picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            picClose.Location = new System.Drawing.Point(708, 0);
            picClose.Name = "picClose";
            picClose.Size = new System.Drawing.Size(30, 35);
            picClose.TabIndex = 1;
            picClose.TabStop = false;
            picClose.Click += new System.EventHandler(picClose_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(3, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 18);
            label1.TabIndex = 0;
            label1.Text = "Product Module";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label7.Location = new System.Drawing.Point(29, 273);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 20);
            label7.TabIndex = 35;
            label7.Text = "Price :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label5.Location = new System.Drawing.Point(29, 182);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 20);
            label5.TabIndex = 29;
            label5.Text = "Brand :";
            // 
            // frmProductModule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(738, 535);
            Controls.Add(label10);
            Controls.Add(textBox1);
            Controls.Add(checkShopware);
            Controls.Add(label9);
            Controls.Add(resultPictureBox);
            Controls.Add(lblQr);
            Controls.Add(UDReOrder);
            Controls.Add(txtPrice);
            Controls.Add(cboCategory);
            Controls.Add(cboBrand);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPdesc);
            Controls.Add(txtBarcode);
            Controls.Add(txtPcode);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label5);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmProductModule";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmProductModule";
            ((System.ComponentModel.ISupportInitialize)(resultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(UDReOrder)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(picClose)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkShopware;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Label lblQr;
        public System.Windows.Forms.NumericUpDown UDReOrder;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.ComboBox cboCategory;
        public System.Windows.Forms.ComboBox cboBrand;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPdesc;
        public System.Windows.Forms.TextBox txtBarcode;
        public System.Windows.Forms.TextBox txtPcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}