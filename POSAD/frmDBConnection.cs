using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAD
{
    public partial class frmDBConnection : Form
    {
        private DBConnect conn;

        public frmDBConnection()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.conn = new DBConnect();
            if ((this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.textBox4.Text == "") && this.comboBox1.Text == "Sql Server Authentication")
            {
                int num1 = (int)MessageBox.Show("Please fill all fields with suitable data!!");
            }
            else if ((this.textBox1.Text == "" || this.textBox2.Text == "") && this.comboBox1.Text == "Windows Authentication")
            {
                int num2 = (int)MessageBox.Show("Please fill the server and database fields with suitable data!!");
            }
            else
            {
                this.conn.server = this.textBox1.Text;
                this.conn.db = this.textBox2.Text;
                this.conn.sql_auth_type = this.comboBox1.Text;
                this.conn.db_user = this.textBox3.Text;
                this.conn.db_pass = this.textBox4.Text;
                using (StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\db_connection.txt"))
                {
                    streamWriter.WriteLine("server:" + this.conn.server);
                    streamWriter.WriteLine("db:" + this.conn.db);
                    streamWriter.WriteLine("db_user:" + this.conn.db_user);
                    streamWriter.WriteLine("db_pass:" + this.conn.db_pass);
                    streamWriter.WriteLine("sql_auth_type:" + this.conn.sql_auth_type);
                }
                try
                {
                    string connectionString;
                    if (this.comboBox1.Text == "Sql Server Authentication")
                        connectionString = "Data Source=" + this.conn.server + ";Initial Catalog=" + this.conn.db + ";Persist Security Info=True;User ID=" + this.conn.db_user + ";Password=" + this.conn.db_pass + ";";
                    else
                        connectionString = "data source=" + this.conn.server + ";Database=" + this.conn.db + ";persist security info=True;   Integrated Security = SSPI; ";
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();
                    sqlConnection.Close();
                    int num3 = (int)MessageBox.Show("The connection to database is succeed ");
                }
                catch (Exception)
                {
                    int num4 = (int)MessageBox.Show("The connection to database is failed,Please fix the seting values");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.comboBox1.Text == "Windows Authentication")
            {
                this.textBox3.Enabled = false;
                this.textBox4.Enabled = false;
            }
            else
            {
                this.textBox3.Enabled = true;
                this.textBox4.Enabled = true;
            }

        }

        private void frmDBConnection_Load(object sender, EventArgs e)
        {

            try
            {
                foreach (string readLine in File.ReadLines(Application.StartupPath + "\\db_connection.txt"))
                {
                    string str1 = "";
                    int num = 0;
                    string str2 = readLine;
                    char[] chArray = new char[1] { ':' };
                    foreach (string str3 in str2.Split(chArray))
                    {
                        ++num;
                        if (num == 1)
                        {
                            str1 = str3;
                        }
                        else
                        {
                            switch (str1)
                            {
                                case "server":
                                    this.textBox1.Text = str3;
                                    break;
                                case "db":
                                    this.textBox2.Text = str3;
                                    break;
                                case "sql_auth_type":
                                    this.comboBox1.Text = str3;
                                    break;
                                case "db_user":
                                    this.textBox3.Text = str3;
                                    break;
                                case "db_pass":
                                    this.textBox4.Text = str3;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Failed to load setting values, " + ex.ToString());
            }
        }


    }
}
