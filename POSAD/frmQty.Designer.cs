namespace POSAD
{
    partial class frmQty
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
            txtQty = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtQty
            // 
            txtQty.Dock = System.Windows.Forms.DockStyle.Fill;
            txtQty.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtQty.Location = new System.Drawing.Point(0, 0);
            txtQty.Multiline = true;
            txtQty.Name = "txtQty";
            txtQty.Size = new System.Drawing.Size(161, 51);
            txtQty.TabIndex = 1;
            txtQty.Text = "1";
            txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtQty_KeyPress);
            // 
            // frmQty
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(161, 51);
            Controls.Add(txtQty);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmQty";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Qty";
            KeyDown += new System.Windows.Forms.KeyEventHandler(frmQty_KeyDown);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQty;
    }
}