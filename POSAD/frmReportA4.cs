using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace POSAD
{
    public partial class frmReportA4 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string store;
        string address;
        string paymentTerms;
        string img;
        frmInvoice cashier;
        clsCustomer cust;

        string loginUserName;
        string loginUserRole;

        public frmReportA4(frmInvoice cash, clsCustomer cus, string username, string role)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cashier = cash;
            cust = cus;

            loginUserName = username;
            loginUserRole = role;

            LoadStore();
        }
        public void LoadStore()
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbStore", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                store = dr["store"].ToString();
                address = dr["address"].ToString();
                paymentTerms = dr["paymentTerms"].ToString();

                byte[] imgData = (byte[])dr["logo"];
                img = Convert.ToBase64String(imgData);
                //using (MemoryStream ms = new MemoryStream(imgData))
                //{
                //   .Image = Image.FromStream(ms);
                //}
            }
            dr.Close();
            cn.Close();
        }

        private void frmReportA4_Load(object sender, EventArgs e)
        {
     
            this.reportViewer1.RefreshReport();
        }


        public void LoadA4Report()
        {
            ReportDataSource rptDataSourece;
            try
            {
                //clsCustomer customer = new clsCustomer();

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptInvoice.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                POSDataSet ds = new POSDataSet();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT c.id, c.transno, c.pcode, c.price, c.qty, c.disc_percent as disc, c.total, c.sdate, c.status, p.pdesc, p.unit, p.tax FROM tbCart AS c INNER JOIN tbProduct AS p ON p.pcode=c.pcode WHERE c.transno LIKE '" + cashier.lblTranNo.Text + "'", cn);
                da.Fill(ds.Tables["dtInvoiceA4"]);
                cn.Close();

                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", cashier.lblTranNo.Text);
                //ReportParameter pVat = new ReportParameter("pVat", cashier.lblVat.Text);
                //ReportParameter pDiscount = new ReportParameter("pDiscount", cashier.lblDiscount.Text);
                //ReportParameter pTotal = new ReportParameter("pTotal", cashier.lblDisplayTotal.Text);
                ////ReportParameter pCash = new ReportParameter("pCash", pcash);
                ////ReportParameter pChange = new ReportParameter("pChange", pchange);
                ReportParameter pStore = new ReportParameter("pStore", store);
                ReportParameter pAddress = new ReportParameter("pAddress", address);
                ReportParameter pPaymentTerms = new ReportParameter("paymentTerms", paymentTerms);
                ReportParameter InvoiceDate = new ReportParameter("InvoiceDate", cashier.lblDate.Text);
                ReportParameter logo = new ReportParameter("logo", img);
                //ReportParameter pTransaction = new ReportParameter("pTransaction", "Invoice #: " + cashier.lblTranNo.Text);
                ReportParameter totallsum = new ReportParameter("tollsum", cashier.lblDisplayTotal.Text);

                //Logged in UserName and Role
                ReportParameter logUserName = new ReportParameter("username", loginUserName);
                ReportParameter logUserRole = new ReportParameter("userrole", loginUserRole);
                


                // Customer Data
                ReportParameter Customer = new ReportParameter("CustomerName", cust.Customer);
                ReportParameter Address = new ReportParameter("CustomerAddress", cust.Address);
                ReportParameter contactPerson = new ReportParameter("ContactPerson", cust.contactPerson);
                ReportParameter Phone = new ReportParameter("Phone", cust.Phone);
                ReportParameter Email = new ReportParameter("Email", cust.Email);
                ReportParameter Fax = new ReportParameter("Fax", cust.Fax);

                // Customer Data
                reportViewer1.LocalReport.SetParameters(InvoiceNo);

                reportViewer1.LocalReport.SetParameters(Customer);
                reportViewer1.LocalReport.SetParameters(Address);
                reportViewer1.LocalReport.SetParameters(contactPerson);
                reportViewer1.LocalReport.SetParameters(Phone);
                reportViewer1.LocalReport.SetParameters(Email);
                reportViewer1.LocalReport.SetParameters(Fax);
                reportViewer1.LocalReport.SetParameters(totallsum);

               
                //reportViewer1.LocalReport.SetParameters(pVat);
                //reportViewer1.LocalReport.SetParameters(pDiscount);
                //reportViewer1.LocalReport.SetParameters(pTotal);
                ////reportViewer1.LocalReport.SetParameters(pCash);
                ////reportViewer1.LocalReport.SetParameters(pChange);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);
                reportViewer1.LocalReport.SetParameters(pPaymentTerms);
                reportViewer1.LocalReport.SetParameters(InvoiceDate);
                reportViewer1.LocalReport.SetParameters(logo);

                reportViewer1.LocalReport.SetParameters(logUserName);
                reportViewer1.LocalReport.SetParameters(logUserRole);

                //reportViewer1.LocalReport.SetParameters(pCashier);





                //rptDataSourece = new ReportDataSource("DataSetA4", ds.Tables["dtInvoiceA4"]);
                rptDataSourece = new ReportDataSource("DataSet2", ds.Tables["dtInvoiceA4"]);
                //rptDataSourece = new ReportDataSource("POSDataSet", ds.Tables["dtInvoiceA4"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSourece);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
               this.WindowState = FormWindowState.Maximized;


            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void frmReportA4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
