﻿namespace POSAD
{
    partial class frmBrandModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrandModule));
            panel1 = new System.Windows.Forms.Panel();
            picClose = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            lblId = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            txtBrand = new System.Windows.Forms.TextBox();
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
            panel1.Size = new System.Drawing.Size(618, 50);
            panel1.TabIndex = 7;
            // 
            // picClose
            // 
            picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            picClose.Location = new System.Drawing.Point(589, 0);
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
            label1.Size = new System.Drawing.Size(112, 18);
            label1.TabIndex = 0;
            label1.Text = "Brand Module";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(12, 150);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(15, 13);
            lblId.TabIndex = 13;
            lblId.Text = "id";
            lblId.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.ForeColor = System.Drawing.Color.Black;
            btnCancel.Location = new System.Drawing.Point(493, 145);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 35);
            btnCancel.TabIndex = 12;
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
            btnUpdate.Location = new System.Drawing.Point(393, 145);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 35);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += new System.EventHandler(btnUpdate_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label2.Location = new System.Drawing.Point(12, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 20);
            label2.TabIndex = 10;
            label2.Text = "Brand Name :";
            // 
            // btnSave
            // 
            btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(293, 145);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 35);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += new System.EventHandler(btnSave_Click);
            // 
            // txtBrand
            // 
            txtBrand.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            txtBrand.Location = new System.Drawing.Point(159, 87);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new System.Drawing.Size(428, 26);
            txtBrand.TabIndex = 8;
            // 
            // frmBrandModule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(618, 192);
            Controls.Add(panel1);
            Controls.Add(lblId);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtBrand);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmBrandModule";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmBrandModule";
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
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtBrand;
    }
}