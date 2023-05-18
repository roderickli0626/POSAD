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

namespace POSAD
{
    public partial class frmDashBoard : Form
    {

        SqlConnection cn = new SqlConnection();
        DBConnect dbcon = new DBConnect();
        public frmDashBoard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {

            string str = DateTime.Now.ToString("yyyy-MM-dd");
            this.lblDalySale.Text = this.dbcon.ExtractData("SELECT ISNULL(SUM(total),0) AS total FROM tbCart WHERE status LIKE 'Sold' AND sdate BETWEEN '" + str + "' AND '" + str + "'").ToString("#,##0.00");
            this.lblTotalProduct.Text = this.dbcon.ExtractData("SELECT COUNT(*) FROM tbProduct").ToString("#,##0");
            this.lblStockOnHand.Text = this.dbcon.ExtractData("SELECT ISNULL(SUM(qty), 0) AS qty FROM tbProduct").ToString("#,##0");
            this.lblCriticalItems.Text = this.dbcon.ExtractData("SELECT COUNT(*) FROM vwCriticalItems").ToString("#,##0");

        }

    }
}
