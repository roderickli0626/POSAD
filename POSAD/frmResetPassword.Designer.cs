namespace POSAD
{
    partial class frmResetPassword
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
            btnOk = new System.Windows.Forms.Button();
            txtNpass = new System.Windows.Forms.TextBox();
            txtResPass = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            btnCancel.ForeColor = System.Drawing.Color.Black;
            btnCancel.Location = new System.Drawing.Point(331, 97);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(89, 30);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
            // 
            // btnOk
            // 
            btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            btnOk.ForeColor = System.Drawing.Color.Black;
            btnOk.Location = new System.Drawing.Point(231, 97);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(89, 30);
            btnOk.TabIndex = 29;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += new System.EventHandler(btnOk_Click);
            // 
            // txtNpass
            // 
            txtNpass.Location = new System.Drawing.Point(187, 24);
            txtNpass.Name = "txtNpass";
            txtNpass.Size = new System.Drawing.Size(233, 20);
            txtNpass.TabIndex = 27;
            txtNpass.UseSystemPasswordChar = true;
            // 
            // txtResPass
            // 
            txtResPass.Location = new System.Drawing.Point(187, 57);
            txtResPass.Name = "txtResPass";
            txtResPass.Size = new System.Drawing.Size(233, 20);
            txtResPass.TabIndex = 28;
            txtResPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            label2.Location = new System.Drawing.Point(12, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(162, 17);
            label2.TabIndex = 25;
            label2.Text = "Confirm new password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            label1.Location = new System.Drawing.Point(12, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 17);
            label1.TabIndex = 26;
            label1.Text = "New password:";
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(438, 140);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtNpass);
            Controls.Add(txtResPass);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmResetPassword";
            Text = "frmResetPassword";
            KeyDown += new System.Windows.Forms.KeyEventHandler(frmResetPassword_KeyDown);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtNpass;
        private System.Windows.Forms.TextBox txtResPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}