﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAD
{
    public partial class frmCategory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public frmCategory()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadCategory();
        }

        public void LoadCategory()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbCategory ORDER BY category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategoryModule module = new frmCategoryModule(this);
            module.ShowDialog();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbCategory WHERE id LIKE '" + dgvCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successfully deleted.", "Point Of Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (colName == "Edit")
            {
                frmCategoryModule module = new frmCategoryModule(this);
                module.lblId.Text = dgvCategory[1, e.RowIndex].Value.ToString();
                module.txtCategory.Text = dgvCategory[2, e.RowIndex].Value.ToString();
                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true;
                module.ShowDialog();
            }
            LoadCategory();
        }
    }
}
