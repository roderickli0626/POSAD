using System.Windows.Forms;

namespace POSAD
{
    partial class frmProductStockIn : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductStockIn));
            dgvProduct = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Select = new System.Windows.Forms.DataGridViewImageColumn();
            panel1 = new System.Windows.Forms.Panel();
            txtSearch = new System.Windows.Forms.TextBox();
            btnClose = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(dgvProduct)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.BackgroundColor = System.Drawing.Color.White;
            dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProduct.ColumnHeadersHeight = 30;
            dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Column1,
            Column2,
            Column4,
            Column8,
            Select});
            dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.Location = new System.Drawing.Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.Size = new System.Drawing.Size(731, 558);
            dgvProduct.TabIndex = 7;
            dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvProduct_CellContentClick);
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.Name = "Column1";
            Column1.Width = 53;
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
            // Column8
            // 
            Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Qty";
            Column8.Name = "Column8";
            Column8.Width = 58;
            // 
            // Select
            // 
            Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Select.HeaderText = "";
            Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            Select.Name = "Select";
            Select.Width = 5;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 558);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(731, 80);
            panel1.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            txtSearch.Location = new System.Drawing.Point(177, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(395, 26);
            txtSearch.TabIndex = 15;
            txtSearch.TextChanged += new System.EventHandler(txtSearch_TextChanged);
            // 
            // btnClose
            // 
            btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnClose.BackColor = System.Drawing.Color.Red;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(630, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(82, 35);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += new System.EventHandler(btnClose_Click);
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            btnAdd.Location = new System.Drawing.Point(930, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(39, 32);
            btnAdd.TabIndex = 1;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.Location = new System.Drawing.Point(7, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 43);
            label1.TabIndex = 0;
            label1.Text = "Product Stock In";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmProductStockIn
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(731, 638);
            ControlBox = false;
            Controls.Add(dgvProduct);
            Controls.Add(panel1);
            Name = "frmProductStockIn";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmProductStockIn";
            KeyDown += new System.Windows.Forms.KeyEventHandler(frmProductStockIn_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(dgvProduct)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private new System.Windows.Forms.DataGridViewImageColumn Select;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}