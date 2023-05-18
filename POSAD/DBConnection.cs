using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


namespace POSAD
{
    internal class DBConnect
    {

        private SqlConnection cn = new SqlConnection();
        private SqlCommand cm = new SqlCommand();
        private SqlDataReader dr;
        private string con;
        public string server;
        public string db;
        public string db_user;
        public string db_pass;
        public string sql_auth_type;
        public bool connection_status = false;

        public string myConnection()
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
                                    this.server = str3;
                                    break;
                                case "db":
                                    this.db = str3;
                                    break;
                                case "sql_auth_type":
                                    this.sql_auth_type = str3;
                                    break;
                                case "db_user":
                                    this.db_user = str3;
                                    break;
                                case "db_pass":
                                    this.db_pass = str3;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            if (this.sql_auth_type == "Sql Server Authentication")
                this.con = "Data Source=" + this.server + ";Initial Catalog=" + this.db + ";Persist Security Info=True;User ID=" + this.db_user + ";Password=" + this.db_pass + ";";
            else
                this.con = "Data Source=" + this.server + ";Initial Catalog=" + this.db + ";Persist Security Info=True;  Integrated Security = SSPI;";
            return this.con;
        }

        public bool check_db_connection()
        {
            this.connection_status = false;
            this.myConnection();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(this.con);
                sqlConnection.Open();
                sqlConnection.Close();
                this.connection_status = true;
            }
            catch (Exception)
            {
                this.connection_status = false;
            }
            return this.connection_status;
        }

        public DataTable getTable(string qury)
        {
            this.cn.ConnectionString = this.myConnection();
            this.cm = new SqlCommand(qury, this.cn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(this.cm);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void ExecuteQuery(string sql)
        {
            try
            {
                this.cn.ConnectionString = this.myConnection();
                this.cn.Open();
                this.cm = new SqlCommand(sql, this.cn);
                this.cm.ExecuteNonQuery();
                this.cn.Close();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message);
            }
        }

        public string getPassword(string username)
        {
            string password = "";
            this.cn.ConnectionString = this.myConnection();
            this.cn.Open();
            this.cm = new SqlCommand("SELECT password FROM tbUser WHERE username = '" + username + "'", this.cn);
            this.dr = this.cm.ExecuteReader();
            this.dr.Read();
            if (this.dr.HasRows)
                password = this.dr["password"].ToString();
            this.dr.Close();
            this.cn.Close();
            return password;
        }

        public double ExtractData(string sql)
        {
            this.cn = new SqlConnection();
            this.cn.ConnectionString = this.myConnection();
            this.cn.Open();
            this.cm = new SqlCommand(sql, this.cn);
            double data = double.Parse(this.cm.ExecuteScalar().ToString());
            this.cn.Close();
            return data;
        }


        internal object ExtractNullableDouble(string v)
        {
            throw new NotImplementedException();
        }
    }
}
