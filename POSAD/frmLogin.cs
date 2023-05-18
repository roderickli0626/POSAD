using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace POSAD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            txtName.Focus();
        }

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public string _pass = "";
        public bool _isactivate;

  

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string str = "";
            string str2 = "";
            string str3 = "";
            try
            {
                dbcon.myConnection();
                if (!dbcon.check_db_connection())
                {
                    MessageBox.Show("The application can not connect to the database, please fix the database settings!!");
                }
                else
                {
                    bool flag;
                    cn.Open();
                    cm = new SqlCommand("Select * From tbUser Where username = @username and password = @password", cn);
                    cm.Parameters.AddWithValue("@username", txtName.Text);
                    cm.Parameters.AddWithValue("@password", txtPass.Text);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (!dr.HasRows)
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                        str = dr["username"].ToString();
                        str2 = dr["name"].ToString();
                        str3 = dr["role"].ToString();
                        _pass = dr["password"].ToString();
                        _isactivate = bool.Parse(dr["isactivate"].ToString());
                    }
                    dr.Close();
                    cn.Close();
                    if (!flag)
                    {
                        MessageBox.Show("Invalid username and password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (!_isactivate)
                    {
                        MessageBox.Show("Account is deactivate. Unable to login", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (str3 == "Cashier")
                    {
                        //MessageBox.Show("Welcome " + str2 + " |", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //txtName.Clear();
                        //txtPass.Clear();
                        //base.Hide();
                        //new Cashier
                        //{
                        //    lblUsername = { Text = str },
                        //    lblname = { Text = str2 + " | " + str3 }
                        //}.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + str2 + " |", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtName.Clear();
                        txtPass.Clear();
                        base.Hide();
                        new frmMain
                        {
                            lblUsername = { Text = str },
                            lblName = { Text = str2 },
                            _pass = _pass
                        }.ShowDialog();
                    }
                }
            }
            catch (Exception exception)
            {
                cn.Close();
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnLogin.PerformClick();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new frmDBConnection().ShowDialog();
        }
    }
}
