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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1yVMOysiT2P8Q-JQHG-U43CvyNtuQBqEw?usp=sharing");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1ttC_6T-rV_UlQyXytWZN91jgfph9cdan?usp=sharing");
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSignUp main = new frmSignUp();
            this.Hide();
            main.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminSignUp main = new frmAdminSignUp();
            this.Hide();
            main.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
