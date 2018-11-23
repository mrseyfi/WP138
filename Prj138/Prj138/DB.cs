using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj138
{
    class DB
    {
        SqlConnection con = new SqlConnection(lib.conString);

        public DataTable citySelect(int IDci)
        {
            string query = "select * from tbl_city where IDci= @IDci or @IDci =0";
            SqlDataAdapter sd = new SqlDataAdapter(query, con);
            sd.SelectCommand.Parameters.AddWithValue("@IDci", IDci);
            DataSet ds = new DataSet();
            sd.Fill(ds, query);

            return ds.Tables[0];  
        }




    }
}
