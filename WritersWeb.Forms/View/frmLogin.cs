using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WritersWeb.Base;
using WritersWeb.Data;
using WritersWeb.Controller;

namespace WritersWeb.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authenticates.CriteriaInfo authParams = new Authenticates.CriteriaInfo();
            string username = txt_uname.Text,
                    password = txt_pword.Text;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                authParams.Username = username;
                authParams.Password = password;
                if (Account.AuthenticateUser(authParams) > 0)
                {
                    Object resObj = new Object();
                    resObj = Account.Result(authParams);

                    frmMain open = new frmMain();
                    open.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Fields missing!!!");
            }       
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

        private void labelX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
