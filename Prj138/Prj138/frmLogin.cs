using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj138
{
    public partial class frmLogin : Form
    {
        bool trustedUser = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = lib.conString;

            string query = "select * from tbl_user where username =@username  and passwords =@passwords ";
            SqlDataAdapter sd = new SqlDataAdapter(query, con);
            sd.SelectCommand.Parameters.AddWithValue("@Username", tbxUsername.Text);
            sd.SelectCommand.Parameters.AddWithValue("@Passwords", tbxPasswords.Text);

            DataSet ds = new DataSet();
            sd.Fill(ds, query);

            if (ds.Tables[query].Rows.Count >0)
            {
                trustedUser = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("خطا");
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
          if(!trustedUser)  Application.Exit();
        }

        private void tbxPasswords_MouseEnter(object sender, EventArgs e)
        {
            tbxPasswords.PasswordChar = '\0';
        }

        private void tbxPasswords_MouseLeave(object sender, EventArgs e)
        {
            tbxPasswords.PasswordChar = '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
