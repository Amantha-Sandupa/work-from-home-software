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
    public partial class frmAdminSignUp : Form
    {
        public frmAdminSignUp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdmin main = new frmAdmin();
            main.Show();
            this.Hide();
        }

        private void frmAdminSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == String.Empty)
            {
                errorProvider2.SetError(txtPassword , "Please Enter Password");
            }

            else if (txtUsername.Text == String.Empty)
            {
                errorProvider3.SetError(txtUsername, "Please Enter Password");
            }

            string cs = @"Data Source=10WINFFQRP72;Initial Catalog=test_app;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            string sql = "INSERT INTO Admin(First_name,Last_name,Username,Password) VALUES('" + this.txtFirstname.Text + "', '" + this.txtLastName.Text + "','" + this.txtUsername.Text + "','" + this.txtPassword.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);

            if (this.txtPassword == this.txtRePassword)
            {
                int i = com.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Saved");

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
            con.Dispose();
        }
    }
}
