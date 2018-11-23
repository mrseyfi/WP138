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

namespace Prj138
{
    public partial class frmTest3 : Form
    {
        public frmTest3()
        {
            InitializeComponent();
        }

        private void frmTest3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB138DataSet.tbl_City' table. You can move, or remove it, as needed.
            this.tbl_CityTableAdapter.Fill(this.dB138DataSet.tbl_City);


            SqlConnection con = new SqlConnection();
            con.ConnectionString = lib.conString;

            SqlDataAdapter sd = new SqlDataAdapter("tbl_city", con);
            DataSet ds = new DataSet();
            sd.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
    }
}
