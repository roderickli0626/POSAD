namespace POSAD
{
    partial class frmStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStore));
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtStName = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnImage = new System.Windows.Forms.Button();
            picLogo = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picLogo)).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 235);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(673, 50);
            panel1.TabIndex = 33;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.Location = new System.Drawing.Point(7, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 43);
            label1.TabIndex = 0;
            label1.Text = "Store Detail";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(442, 193);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 35);
            btnSave.TabIndex = 38;
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
            btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            btnCancel.ForeColor = System.Drawing.Color.Black;
            btnCancel.Location = new System.Drawing.Point(548, 194);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 35);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
            // 
            // txtStName
            // 
            txtStName.Location = new System.Drawing.Point(169, 17);
            txtStName.Name = "txtStName";
            txtStName.Size = new System.Drawing.Size(473, 20);
            txtStName.TabIndex = 36;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(169, 56);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(473, 20);
            txtAddress.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label3.Location = new System.Drawing.Point(50, 59);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 20);
            label3.TabIndex = 34;
            label3.Text = "Address :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label2.Location = new System.Drawing.Point(50, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 20);
            label2.TabIndex = 35;
            label2.Text = "Store Name :";
            // 
            // btnImage
            // 
            btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnImage.FlatAppearance.BorderSize = 0;
            btnImage.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            btnImage.ForeColor = System.Drawing.Color.Black;
            btnImage.Location = new System.Drawing.Point(319, 98);
            btnImage.Name = "btnImage";
            btnImage.Size = new System.Drawing.Size(94, 32);
            btnImage.TabIndex = 40;
            btnImage.Text = "Brows";
            btnImage.UseVisualStyleBackColor = false;
            btnImage.Click += new System.EventHandler(btnImage_Click);
            // 
            // picLogo
            // 
            picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picLogo.Location = new System.Drawing.Point(54, 136);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(359, 92);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 41;
            picLogo.TabStop = false;
            // 
            // frmStore
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(673, 285);
            ControlBox = false;
            Controls.Add(picLogo);
            Controls.Add(btnImage);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtStName);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmStore";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmStore";
            KeyDown += new System.Windows.Forms.KeyEventHandler(frmStore_KeyDown);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(picLogo)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox picLogo;
    }
}