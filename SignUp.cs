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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain mainform = new frmMain();
            mainform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=10WINFFQRP72;Initial Catalog=test_app;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            string sql = "INSERT INTO user_details(first_name,last_name,user_name,pass_word) VALUES('"+this.txtfName.Text +"', '" + this.txtlName.Text + "','" + this.txtuName.Text + "','"+this.txtpWord.Text+"')";
            SqlCommand com = new SqlCommand(sql, con);
            int i = com.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("Saved");
                frmLogIn main = new frmLogIn();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
            
            con.Dispose();
        }

        private void txtfName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrepWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
