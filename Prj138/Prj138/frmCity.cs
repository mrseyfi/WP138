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
    public partial class frmCity : Prj138.frmThem
    {
        public frmCity()
        {
            InitializeComponent();
        }

        private void frmCity_Load(object sender, EventArgs e)
        {
         
            cmbTitleCi.ValueMember = "IDCi";
            cmbTitleCi.DisplayMember = "titleCi";
            cmbTitleCi.DataSource = new DB().citySelect(0);
        }
    }
}
