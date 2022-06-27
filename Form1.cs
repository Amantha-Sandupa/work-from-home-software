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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtPassWord.Text == String.Empty)
            {
                errorProvider1.SetError(txtPassWord, "Please Enter Password");
            }

            string username, password;
            password = this.txtPassWord.Text;
            username = this.txtUsrname.Text;

            string cs = @"Data Source=10WINFFQRP72;Initial Catalog=test_app;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //define a command
            string sql = "SELECT * FROM user_details WHERE user_name='" + username + "'AND pass_word='" + password + "'";
            SqlCommand com = new SqlCommand(sql, con);

            //Accces data using Datareader Method
            SqlDataReader dr = com.ExecuteReader();

            //bind data with controls
            if (dr.Read())
            {
                //open the main form
                first_page main = new first_page();
                main.Show();
                this.Hide();
                MessageBox.Show("Logged In", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            // else
            {
                MessageBox.Show("");
            }
             


            //Close the connection
            con.Dispose();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmMain mainform = new frmMain();
            mainform.Show();
            this.Hide();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
