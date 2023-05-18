using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAD
{
    public partial class frmAlert : Form
    {

        private Random random;
        private int tempIndex;
        frmMain main;
        public frmAlert(frmMain mn)
        {
            InitializeComponent();
            random = new Random();
            Color color = SelectThemeColor();
            panel1.BackColor = color;
            main = mn;
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        private frmAlert.enmAction action;
        private int x, y;

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                //if the color has already been selected, we select again to choose a different one.
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case enmAction.wait:
                    timer1.Interval = 15000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    Opacity -= 0.1;

                    Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            frmStockIn stock = new frmStockIn(main);
            main.openChildForm(stock);
            frmProductStockIn stockIn = new frmProductStockIn(stock);
            stock.ProductForSupplier(lblPcode.Text);
            stockIn.addStockIn(lblPcode.Text);
        }

        public void showAlert(string msg)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                frmAlert frm = (frmAlert)Application.OpenForms[fname];

                if (frm == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;
                }

            }
            x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            lblMsg.Text = msg;

            Show();
            action = enmAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }
    }
}
