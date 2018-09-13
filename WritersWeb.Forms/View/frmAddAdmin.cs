using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritersWeb.View
{
    public partial class frmAddAdmin : Form
    {
        public frmAddAdmin()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isHold = false;
        private int[] mousepost = { 0, 0 };
        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isHold = true;
                mousepost[0] = e.X;
                mousepost[1] = e.Y;
            }
            else isHold = false;
        }

        private void pnlMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isHold)
                this.Location = new Point(this.Location.X + e.X - mousepost[0], this.Location.Y + e.Y - mousepost[1]);
        }

        private void pnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            isHold = false;
        }
    }
}
