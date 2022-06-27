using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace guiSample1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogIn mainform = new frmLogIn();
            mainform.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult msgbx =MessageBox.Show("Want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msgbx == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSignUp mainform = new frmSignUp();
            mainform.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmadminlog mainform = new frmadminlog();
            mainform.Show();
            this.Hide();
        }
    }
}
