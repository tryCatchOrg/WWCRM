using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WritersWeb.View;

namespace WritersWeb.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        //frmDashboard dash;
        frmAdmin admin;
        frmEmployee employee;
        frmLead lead;
        frmFulfillment fulfillment;
        frmProduction production;
        frmPurchase purchased;
        frmSales sales;
        frmTrack track;
        frmMemo memo;
        //frmSetting setting;
        frmReports report;


        frmAddLead lead_add;
        frmAddEmployee employee_add;
        frmAddAdmin admin_add;
        frmAddMemo memo_add;
        frmPayment payment;

        private void frmMain_Load(object sender, EventArgs e)
        {
            assign_btn(btnDashboard);
            assign_btn(btnAdmin);
            assign_btn(btnEmployee);
            assign_btn(btnSales);
            assign_btn(btnLeads);
            assign_btn(btnProduction);
            assign_btn(btnTrack);
            assign_btn(btnMemo);
            assign_btn(btnFulfillment);
            assign_btn(btnReports);
            assign_btn(btnSetting);
        }

        private void assign_btn(DevComponents.DotNetBar.ButtonX btn)
        {
            btn.MouseLeave += new System.EventHandler(btn_MouseLeave);
            btn.MouseEnter += new System.EventHandler(btn_MouseEnter);
            btn.Click += new System.EventHandler(btn_MouseClick);
        }

        private void closeFrms()
        {
            if (lead != null) lead.pnlMain.Hide(); 
            //if (dash != null) dash.pnlMain.Hide(); 
            if (admin != null) admin.pnlMain.Hide();
            if (employee != null) employee.pnlMain.Hide();
            if (fulfillment != null) fulfillment.pnlMain.Hide(); 
            if (production != null) production.pnlMain.Hide(); 
            if (purchased != null) purchased.pnlMain.Hide(); 
            if (sales != null) sales.pnlMain.Hide(); 
            if (track != null) track.pnlMain.Hide(); 
            if (memo != null) memo.pnlMain.Hide(); 
            //if (setting != null) setting.pnlMain.Hide(); 
            if (report != null) report.pnlMain.Hide();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            var btn_convert = sender as DevComponents.DotNetBar.ButtonX;
            btn_convert.BackColor = Color.LightSeaGreen;
            btn_convert.SymbolColor = Color.White;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            var btn_convert = sender as DevComponents.DotNetBar.ButtonX;
            btn_convert.BackColor = Color.Transparent;
            btn_convert.SymbolColor = Color.Gainsboro;
        }
 
        public void btn_MouseClick(object sender, EventArgs e)
        {
            var btn_convert = sender as DevComponents.DotNetBar.ButtonX;
            string n = btn_convert.Name;
            if (n == "btnDashboard")
            {
                closeFrms();
                lblCrump.Text = "Dashboard";
                lblSymbol.Symbol = "";
                //if (dash != null) {
                //    dash.pnlMain.Show();
                //} 
                //else
                //{
                //    dash = new frmDashboard();
                //    dash.pnlMain.Parent = this.mainWrap;
                //}
            }
            else if (n == "btnAdmin")
            {
                closeFrms();
                lblCrump.Text = "Administrator";
                lblSymbol.Symbol = "";
                if (admin != null)
                {
                    admin.pnlMain.Show();
                }
                else
                {
                    admin = new frmAdmin();
                    admin.pnlMain.Parent = this.mainWrap;
                }
            }
            else if (n == "btnEmployee")
            {
                closeFrms();
                lblCrump.Text = "Manage Employee";
                lblSymbol.Symbol = "";
                if (employee != null)
                {
                    employee.pnlMain.Show();
                }
                else
                {
                    employee = new frmEmployee();
                    employee.pnlMain.Parent = this.mainWrap;
                }
            }
            else if (n == "btnSales")
            {
                closeFrms();
                lblCrump.Text = "Manage Sales";
                lblSymbol.Symbol = "";
                if (sales != null)
                {
                    sales.pnlMain.Show();
                }
                else
                {
                    sales = new frmSales();
                    sales.pnlMain.Parent = this.mainWrap;
                }
            }
            else if (n == "btnLeads")
            {
                closeFrms();
                lblCrump.Text = "Manage Leads";
                lblSymbol.Symbol = "";
                if (lead != null)
                {
                    lead.pnlMain.Show();
                }
                else
                {
                    lead = new frmLead();
                    lead.pnlMain.Parent = this.mainWrap;
                }
            }
            else if (n == "btnFulfillment")
            {
                closeFrms();
                lblCrump.Text = "Manage Fulfillment";
                lblSymbol.Symbol = "";
                if (fulfillment != null)
                {
                    fulfillment.pnlMain.Show();
                }
                else
                {
                    fulfillment = new frmFulfillment();
                    fulfillment.pnlMain.Parent = this.mainWrap;
                }
            }
            else if (n == "btnProduction")
            {
                closeFrms();
                lblCrump.Text = "Manage Projects";
                lblSymbol.Symbol = "";
                if (production != null)
                {
                    production.pnlMain.Show();
                }
                else
                {
                    production = new frmProduction();
                    production.pnlMain.Parent = this.mainWrap;
                }
            }
            else if (n == "btnTrack")
            {
                closeFrms();
                lblCrump.Text = "Track Sales";
                lblSymbol.Symbol = "";
                if (track != null)
                {
                    track.pnlMain.Show();
                }
                else
                {
                    track = new frmTrack();
                    track.pnlMain.Parent = this.mainWrap;
                }
            }
            else if (n == "btnMemo")
            {
                closeFrms();
                lblCrump.Text = "Manage Memo";
                lblSymbol.Symbol = "";
                if (memo != null)
                {
                    memo.pnlMain.Show();
                }
                else
                {
                    memo = new frmMemo();
                    memo.pnlMain.Parent = this.mainWrap;
                }
            }
            else if (n == "btnSetting")
            {
                closeFrms();
                lblCrump.Text = "Settings";
                lblSymbol.Symbol = "";
                //if (setting != null)
                //{
                //    setting.pnlMain.Show();
                //}
                //else
                //{
                //    setting = new frmSetting();
                //    setting.pnlMain.Parent = this.mainWrap;
                //}
            }
            else if (n == "btnReports")
            {
                closeFrms();
                lblCrump.Text = "Manage Reports";
                lblSymbol.Symbol = "";
                if (report != null)
                {
                    report.pnlMain.Show();
                }
                else
                {
                    report = new frmReports();
                    report.pnlMain.Parent = this.mainWrap;
                }
            }
            else if (n == "btnAddLead")
            {
                lead_add = new frmAddLead();
                lead_add.ShowDialog();
            }
            else if (n == "btnAddEmployee")
            {
                employee_add = new frmAddEmployee();
                employee_add.ShowDialog();
            }
            else if (n == "btnAddAdmin")
            {
                admin_add = new frmAddAdmin();
                admin_add.ShowDialog();
            }
            else if (n == "btnAddMemo")
            {
                memo_add = new frmAddMemo();
                memo_add.ShowDialog();
            }
            else if (n == "btnPurchase")
            {
                payment = new frmPayment();
                payment.ShowDialog();
            }

        }

        private void labelX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            MinimumSize = this.Size;
            MaximumSize = this.Size;
        }

        private void labelX2_MouseHover(object sender, EventArgs e)
        {
            labelX2.SymbolColor = Color.DarkCyan;
        }

        private void labelX4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private bool isHold = false;
        private int[] mousepost = { 0, 0 };

        private void ev_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isHold = true;
                mousepost[0] = e.X;
                mousepost[1] = e.Y;
            }
            else isHold = false;
        }

        private void ev_MouseUp(object sender, MouseEventArgs e)
        {
            isHold = false;
        }

        private void ev_MouseMove(object sender, MouseEventArgs e)
        {
            if (isHold)
                this.Location = new Point(this.Location.X + e.X - mousepost[0], this.Location.Y + e.Y - mousepost[1]);
        }

    }
}
