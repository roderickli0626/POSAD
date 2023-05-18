namespace POSAD
{
    partial class frmDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscount));
            panel1 = new System.Windows.Forms.Panel();
            picClose = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            txtDiscAmount = new System.Windows.Forms.TextBox();
            txtDiscount = new System.Windows.Forms.TextBox();
            txtTotalPrice = new System.Windows.Forms.TextBox();
            lbId = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picClose)).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(416, 50);
            panel1.TabIndex = 12;
            // 
            // picClose
            // 
            picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            picClose.Location = new System.Drawing.Point(387, 0);
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
            label1.Size = new System.Drawing.Size(71, 18);
            label1.TabIndex = 0;
            label1.Text = "Discount";
            // 
            // btnSave
            // 
            btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(301, 192);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 35);
            btnSave.TabIndex = 20;
            btnSave.Text = "Confirm";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += new System.EventHandler(btnSave_Click);
            // 
            // txtDiscAmount
            // 
            txtDiscAmount.Enabled = false;
            txtDiscAmount.Location = new System.Drawing.Point(164, 157);
            txtDiscAmount.Name = "txtDiscAmount";
            txtDiscAmount.Size = new System.Drawing.Size(231, 20);
            txtDiscAmount.TabIndex = 17;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new System.Drawing.Point(140, 121);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new System.Drawing.Size(255, 20);
            txtDiscount.TabIndex = 18;
            txtDiscount.TextChanged += new System.EventHandler(txtDiscount_TextChanged);
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Location = new System.Drawing.Point(140, 85);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new System.Drawing.Size(255, 20);
            txtTotalPrice.TabIndex = 19;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new System.Drawing.Point(12, 196);
            lbId.Name = "lbId";
            lbId.Size = new System.Drawing.Size(15, 13);
            lbId.TabIndex = 13;
            lbId.Text = "id";
            lbId.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label4.Location = new System.Drawing.Point(17, 160);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(141, 20);
            label4.TabIndex = 14;
            label4.Text = "Discount Amount :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label3.Location = new System.Drawing.Point(17, 124);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(106, 20);
            label3.TabIndex = 15;
            label3.Text = "Discount (%) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label2.Location = new System.Drawing.Point(17, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 20);
            label2.TabIndex = 16;
            label2.Text = "Total Price :";
            // 
            // frmDiscount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(416, 239);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(txtDiscAmount);
            Controls.Add(txtDiscount);
            Controls.Add(txtTotalPrice);
            Controls.Add(lbId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmDiscount";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmDiscount";
            KeyDown += new System.Windows.Forms.KeyEventHandler(frmDiscount_KeyDown);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(picClose)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtDiscAmount;
        public System.Windows.Forms.TextBox txtDiscount;
        public System.Windows.Forms.TextBox txtTotalPrice;
        public System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}