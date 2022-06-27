using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiSample1
{
    public partial class first_page : Form
    {
        public first_page()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain mainform = new frmMain();
            mainform.Show();
            this.Hide();
        }

        private void btnFb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/");
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMain mainform = new frmMain();
            mainform.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult msgbx = MessageBox.Show("Want to exit?", "Exit From the app", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msgbx == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void paymentsRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\Salila Enterprise");
        }

        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSignUp mainform = new frmSignUp();
            mainform.Show();
            this.Close();
        }

        private void first_page_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1yVMOysiT2P8Q-JQHG-U43CvyNtuQBqEw?usp=sharing");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1ttC_6T-rV_UlQyXytWZN91jgfph9cdan?usp=sharing");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\\Visual Studio Projects\Coursework\Subbittions");
        }
    }
}
