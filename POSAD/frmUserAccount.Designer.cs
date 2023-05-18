namespace POSAD
{
    partial class frmUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            tabPage3 = new System.Windows.Forms.TabPage();
            btnAccSave = new System.Windows.Forms.Button();
            btnAccCancel = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            cbRole = new System.Windows.Forms.ComboBox();
            txtRePass = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            txtUsername = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnPassSave = new System.Windows.Forms.Button();
            btnPassCancel = new System.Windows.Forms.Button();
            txtRePass2 = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            txtNPass = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            txtCurPass = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            btnProperties = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            dgvUser = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gbUser = new System.Windows.Forms.GroupBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            lblAccNote = new System.Windows.Forms.Label();
            btnResetPass = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dgvUser)).BeginInit();
            gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new System.Drawing.Point(42, 34);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(817, 444);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAccSave);
            tabPage1.Controls.Add(btnAccCancel);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(cbRole);
            tabPage1.Controls.Add(txtRePass);
            tabPage1.Controls.Add(txtPass);
            tabPage1.Controls.Add(txtUsername);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(809, 418);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create Account";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblUsername);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(btnPassSave);
            tabPage2.Controls.Add(btnPassCancel);
            tabPage2.Controls.Add(txtRePass2);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(txtNPass);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtCurPass);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new System.Drawing.Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(809, 418);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Change Password";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(gbUser);
            tabPage3.Controls.Add(btnProperties);
            tabPage3.Controls.Add(btnRemove);
            tabPage3.Controls.Add(dgvUser);
            tabPage3.Location = new System.Drawing.Point(4, 22);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(809, 418);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Activate/ UnActivate Account";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAccSave
            // 
            btnAccSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnAccSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            btnAccSave.FlatAppearance.BorderSize = 0;
            btnAccSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccSave.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            btnAccSave.ForeColor = System.Drawing.Color.White;
            btnAccSave.Location = new System.Drawing.Point(545, 330);
            btnAccSave.Name = "btnAccSave";
            btnAccSave.Size = new System.Drawing.Size(94, 35);
            btnAccSave.TabIndex = 43;
            btnAccSave.Text = "Save";
            btnAccSave.UseVisualStyleBackColor = false;
            btnAccSave.Click += new System.EventHandler(btnAccSave_Click);
            // 
            // btnAccCancel
            // 
            btnAccCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnAccCancel.BackColor = System.Drawing.Color.Gainsboro;
            btnAccCancel.FlatAppearance.BorderSize = 0;
            btnAccCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            btnAccCancel.ForeColor = System.Drawing.Color.Black;
            btnAccCancel.Location = new System.Drawing.Point(659, 330);
            btnAccCancel.Name = "btnAccCancel";
            btnAccCancel.Size = new System.Drawing.Size(94, 35);
            btnAccCancel.TabIndex = 44;
            btnAccCancel.Text = "Cancel";
            btnAccCancel.UseVisualStyleBackColor = false;
            btnAccCancel.Click += new System.EventHandler(btnAccCancel_Click);
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(226, 259);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(527, 20);
            txtName.TabIndex = 42;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] {
            "Administrator",
            "Cashier"});
            cbRole.Location = new System.Drawing.Point(226, 206);
            cbRole.Name = "cbRole";
            cbRole.Size = new System.Drawing.Size(527, 21);
            cbRole.TabIndex = 41;
            // 
            // txtRePass
            // 
            txtRePass.Location = new System.Drawing.Point(226, 155);
            txtRePass.Name = "txtRePass";
            txtRePass.Size = new System.Drawing.Size(527, 20);
            txtRePass.TabIndex = 38;
            txtRePass.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            txtPass.Location = new System.Drawing.Point(226, 104);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(527, 20);
            txtPass.TabIndex = 39;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(226, 53);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(527, 20);
            txtUsername.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label6.Location = new System.Drawing.Point(56, 260);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(87, 20);
            label6.TabIndex = 33;
            label6.Text = "Full Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label5.Location = new System.Drawing.Point(56, 209);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 20);
            label5.TabIndex = 34;
            label5.Text = "Role :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label4.Location = new System.Drawing.Point(56, 158);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(148, 20);
            label4.TabIndex = 35;
            label4.Text = "Re-type Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label3.Location = new System.Drawing.Point(56, 107);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 20);
            label3.TabIndex = 36;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label2.Location = new System.Drawing.Point(56, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 20);
            label2.TabIndex = 37;
            label2.Text = "Username :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUsername.Location = new System.Drawing.Point(122, 84);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(82, 18);
            lblUsername.TabIndex = 46;
            lblUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(60, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(50, 50);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // btnPassSave
            // 
            btnPassSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnPassSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            btnPassSave.FlatAppearance.BorderSize = 0;
            btnPassSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPassSave.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            btnPassSave.ForeColor = System.Drawing.Color.White;
            btnPassSave.Location = new System.Drawing.Point(545, 332);
            btnPassSave.Name = "btnPassSave";
            btnPassSave.Size = new System.Drawing.Size(94, 35);
            btnPassSave.TabIndex = 43;
            btnPassSave.Text = "Save";
            btnPassSave.UseVisualStyleBackColor = false;
            btnPassSave.Click += new System.EventHandler(btnPassSave_Click);
            // 
            // btnPassCancel
            // 
            btnPassCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnPassCancel.BackColor = System.Drawing.Color.Gainsboro;
            btnPassCancel.FlatAppearance.BorderSize = 0;
            btnPassCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPassCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            btnPassCancel.ForeColor = System.Drawing.Color.Black;
            btnPassCancel.Location = new System.Drawing.Point(659, 332);
            btnPassCancel.Name = "btnPassCancel";
            btnPassCancel.Size = new System.Drawing.Size(94, 35);
            btnPassCancel.TabIndex = 44;
            btnPassCancel.Text = "Cancel";
            btnPassCancel.UseVisualStyleBackColor = false;
            btnPassCancel.Click += new System.EventHandler(btnPassCancel_Click);
            // 
            // txtRePass2
            // 
            txtRePass2.Location = new System.Drawing.Point(226, 245);
            txtRePass2.Name = "txtRePass2";
            txtRePass2.Size = new System.Drawing.Size(527, 20);
            txtRePass2.TabIndex = 42;
            txtRePass2.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label10.Location = new System.Drawing.Point(56, 248);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(148, 20);
            label10.TabIndex = 41;
            label10.Text = "Re-type Password :";
            // 
            // txtNPass
            // 
            txtNPass.Location = new System.Drawing.Point(226, 187);
            txtNPass.Name = "txtNPass";
            txtNPass.Size = new System.Drawing.Size(527, 20);
            txtNPass.TabIndex = 40;
            txtNPass.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label9.Location = new System.Drawing.Point(56, 190);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(126, 20);
            label9.TabIndex = 39;
            label9.Text = "New Password :";
            // 
            // txtCurPass
            // 
            txtCurPass.Location = new System.Drawing.Point(226, 132);
            txtCurPass.Name = "txtCurPass";
            txtCurPass.Size = new System.Drawing.Size(527, 20);
            txtCurPass.TabIndex = 38;
            txtCurPass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            label8.Location = new System.Drawing.Point(56, 135);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(146, 20);
            label8.TabIndex = 37;
            label8.Text = "Current Password :";
            // 
            // btnProperties
            // 
            btnProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnProperties.FlatAppearance.BorderSize = 0;
            btnProperties.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            btnProperties.ForeColor = System.Drawing.Color.Black;
            btnProperties.Location = new System.Drawing.Point(692, 249);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new System.Drawing.Size(111, 35);
            btnProperties.TabIndex = 25;
            btnProperties.Text = "Properties";
            btnProperties.UseVisualStyleBackColor = false;
            btnProperties.Click += new System.EventHandler(btnProperties_Click);
            // 
            // btnRemove
            // 
            btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            btnRemove.ForeColor = System.Drawing.Color.Black;
            btnRemove.Location = new System.Drawing.Point(580, 249);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(106, 35);
            btnRemove.TabIndex = 24;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += new System.EventHandler(btnRemove_Click);
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dgvUser.BackgroundColor = System.Drawing.Color.White;
            dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUser.ColumnHeadersHeight = 30;
            dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Column1,
            Column2,
            Column3,
            Column5,
            Column4});
            dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.Location = new System.Drawing.Point(6, 6);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersVisible = false;
            dgvUser.Size = new System.Drawing.Size(797, 237);
            dgvUser.TabIndex = 23;
            dgvUser.SelectionChanged += new System.EventHandler(dgvUser_SelectionChanged);
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
            Column2.HeaderText = "User Name";
            Column2.Name = "Column2";
            Column2.Width = 112;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Full Name";
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Account Activate";
            Column5.Name = "Column5";
            Column5.Width = 164;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Role";
            Column4.Name = "Column4";
            Column4.Width = 64;
            // 
            // gbUser
            // 
            gbUser.BackColor = System.Drawing.Color.White;
            gbUser.Controls.Add(pictureBox2);
            gbUser.Controls.Add(lblAccNote);
            gbUser.Controls.Add(btnResetPass);
            gbUser.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            gbUser.Location = new System.Drawing.Point(6, 312);
            gbUser.Name = "gbUser";
            gbUser.Size = new System.Drawing.Size(797, 100);
            gbUser.TabIndex = 26;
            gbUser.TabStop = false;
            gbUser.Text = "Password For UserName";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(22, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(50, 50);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblAccNote
            // 
            lblAccNote.AutoSize = true;
            lblAccNote.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            lblAccNote.Location = new System.Drawing.Point(103, 27);
            lblAccNote.Name = "lblAccNote";
            lblAccNote.Size = new System.Drawing.Size(453, 20);
            lblAccNote.TabIndex = 0;
            lblAccNote.Text = "To change the password for username, click Reset Password.";
            // 
            // btnResetPass
            // 
            btnResetPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnResetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnResetPass.FlatAppearance.BorderSize = 0;
            btnResetPass.ForeColor = System.Drawing.Color.Black;
            btnResetPass.Location = new System.Drawing.Point(569, 59);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new System.Drawing.Size(222, 35);
            btnResetPass.TabIndex = 22;
            btnResetPass.Text = "Reset Password...";
            btnResetPass.UseVisualStyleBackColor = false;
            btnResetPass.Click += new System.EventHandler(btnResetPass_Click);
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 487);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(892, 80);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.Location = new System.Drawing.Point(7, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 43);
            label1.TabIndex = 0;
            label1.Text = "User Setting";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmUserAccount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(892, 567);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "frmUserAccount";
            Text = "frmUserAccount";
            Load += new System.EventHandler(frmUserAccount_Load);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dgvUser)).EndInit();
            gbUser.ResumeLayout(false);
            gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Button btnAccSave;
        public System.Windows.Forms.Button btnAccCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnPassSave;
        public System.Windows.Forms.Button btnPassCancel;
        private System.Windows.Forms.TextBox txtRePass2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCurPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAccNote;
        public System.Windows.Forms.Button btnResetPass;
        public System.Windows.Forms.Button btnProperties;
        public System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}