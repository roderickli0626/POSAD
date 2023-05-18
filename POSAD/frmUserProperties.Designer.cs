namespace POSAD
{
    partial class frmUserProperties
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
            btnCancel = new System.Windows.Forms.Button();
            btnApply = new System.Windows.Forms.Button();
            cbActivate = new System.Windows.Forms.ComboBox();
            cbRole = new System.Windows.Forms.ComboBox();
            txtName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            btnCancel.ForeColor = System.Drawing.Color.Black;
            btnCancel.Location = new System.Drawing.Point(383, 178);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(89, 30);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
            // 
            // btnApply
            // 
            btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            btnApply.ForeColor = System.Drawing.Color.Black;
            btnApply.Location = new System.Drawing.Point(283, 178);
            btnApply.Name = "btnApply";
            btnApply.Size = new System.Drawing.Size(89, 30);
            btnApply.TabIndex = 33;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += new System.EventHandler(btnApply_Click);
            // 
            // cbActivate
            // 
            cbActivate.FormattingEnabled = true;
            cbActivate.Items.AddRange(new object[] {
            "True",
            "False"});
            cbActivate.Location = new System.Drawing.Point(130, 129);
            cbActivate.Name = "cbActivate";
            cbActivate.Size = new System.Drawing.Size(342, 21);
            cbActivate.TabIndex = 32;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] {
            "Administrator",
            "Cashier"});
            cbRole.Location = new System.Drawing.Point(130, 83);
            cbRole.Name = "cbRole";
            cbRole.Size = new System.Drawing.Size(342, 21);
            cbRole.TabIndex = 31;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(130, 37);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(342, 20);
            txtName.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label3.Location = new System.Drawing.Point(22, 132);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 20);
            label3.TabIndex = 29;
            label3.Text = "Activate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label2.Location = new System.Drawing.Point(22, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 20);
            label2.TabIndex = 28;
            label2.Text = "Role:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label1.Location = new System.Drawing.Point(22, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 20);
            label1.TabIndex = 27;
            label1.Text = "Full name:";
            // 
            // frmUserProperties
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(491, 220);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(cbActivate);
            Controls.Add(cbRole);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmUserProperties";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmUserProperties";
            KeyDown += new System.Windows.Forms.KeyEventHandler(frmUserProperties_KeyDown);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnApply;
        public System.Windows.Forms.ComboBox cbActivate;
        public System.Windows.Forms.ComboBox cbRole;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}