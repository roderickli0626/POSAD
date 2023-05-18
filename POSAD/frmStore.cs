using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace POSAD
{
    public partial class frmStore : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        bool havestoreinfo = false;
        string imgloc;

        public frmStore()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadStore();
        }

        public void LoadStore()
        {
            try
            {

                if (picLogo.Image == null)
                {
                   btnSave.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                }

                cn.Open();
                cm = new SqlCommand("SELECT * FROM tbStore", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    havestoreinfo = true;
                    txtStName.Text = dr["store"].ToString();
                    txtAddress.Text = dr["address"].ToString();

                    byte[] imgData = (byte[])dr["logo"];
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        picLogo.Image = Image.FromStream(ms);
                    }

                }
                else
                {
                    txtStName.Clear();
                    txtAddress.Clear();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            cn.ConnectionString = dbcon.myConnection();
            cn.Open();

            try
            {
                byte[] img;
                using (MemoryStream ms = new MemoryStream())
                {
                    picLogo.Image.Save(ms, ImageFormat.Jpeg);
                    img = ms.ToArray();
                }

                if (MessageBox.Show("Save store details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (havestoreinfo)
                    {
                        cm = new SqlCommand("UPDATE tbStore SET store=@store, address=@address, logo=CONVERT(varbinary(max), @img)", cn);
                        cm.Parameters.AddWithValue("@store", txtStName.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@img", img);
                    }
                    else
                    {
                        cm = new SqlCommand("INSERT INTO tbStore (store, address, logo) VALUES (@store, @address, CONVERT(varbinary(max), @img))", cn);
                        cm.Parameters.AddWithValue("@store", txtStName.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@img", img);
                    }

                    cm.ExecuteNonQuery();

                    MessageBox.Show("Store detail has been successfully saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                cn.Close();
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmStore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { Dispose(); }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgloc = openFileDialog1.FileName.ToString();
                picLogo.ImageLocation = imgloc;
                btnSave.Enabled = true;
            }
        }
    }
}
