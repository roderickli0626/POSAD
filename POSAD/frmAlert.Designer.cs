namespace POSAD
{
    partial class frmAlert
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlert));
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new System.Windows.Forms.Panel();
            lblPcode = new System.Windows.Forms.Label();
            lblMsg = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            btnReorder = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += new System.EventHandler(timer1_Tick);
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPcode);
            panel1.Controls.Add(lblMsg);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnReorder);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(374, 72);
            panel1.TabIndex = 1;
            // 
            // lblPcode
            // 
            lblPcode.AutoSize = true;
            lblPcode.Location = new System.Drawing.Point(343, 54);
            lblPcode.Name = "lblPcode";
            lblPcode.Size = new System.Drawing.Size(15, 13);
            lblPcode.TabIndex = 7;
            lblPcode.Text = "lb";
            lblPcode.Visible = false;
            // 
            // lblMsg
            // 
            lblMsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMsg.ForeColor = System.Drawing.Color.White;
            lblMsg.Location = new System.Drawing.Point(73, 8);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new System.Drawing.Size(245, 57);
            lblMsg.TabIndex = 6;
            lblMsg.Text = "Message Text";
            lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            btnClose.Location = new System.Drawing.Point(324, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(31, 31);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += new System.EventHandler(btnClose_Click);
            // 
            // btnReorder
            // 
            btnReorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReorder.BackgroundImage")));
            btnReorder.Enabled = false;
            btnReorder.FlatAppearance.BorderSize = 0;
            btnReorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReorder.ForeColor = System.Drawing.Color.White;
            btnReorder.Location = new System.Drawing.Point(12, 11);
            btnReorder.Name = "btnReorder";
            btnReorder.Size = new System.Drawing.Size(50, 50);
            btnReorder.TabIndex = 4;
            btnReorder.UseVisualStyleBackColor = true;
            btnReorder.Click += new System.EventHandler(btnReorder_Click);
            // 
            // frmAlert
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Highlight;
            ClientSize = new System.Drawing.Size(374, 72);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmAlert";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmAlert";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblPcode;
        public System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnReorder;
    }
}