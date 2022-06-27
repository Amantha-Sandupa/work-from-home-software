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
    public partial class frmadminlog : Form
    {
        public frmadminlog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            frmMain mainform = new frmMain();
            mainform.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username,password;
            username = this.txtUsernam.Text;
            password = this.txtPassword.Text;

            string cs = "Data Source=10WINFFQRP72;Initial Catalog=test_app;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //define a command
            string sql = "SELECT * FROM Admin WHERE Username ='"+ username + "' AND Password ='"+ password +"'";
            SqlCommand com = new SqlCommand(sql, con);

            //Accces data using Datareader Method
            //SqlDataReader dr = com.ExecuteReader();


            int i = com.ExecuteNonQuery();

            if (i != 0)
            {
                frmAdmin main = new frmAdmin();
                main.Show();
                this.Hide();
                MessageBox.Show("Logged");
            }
            else
            {
                MessageBox.Show("Error");
            }
            con.Dispose();
        }
    }
}
