using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efmbchir
{
    class ADO
    {
        public SqlConnection cnx = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public SqlDataAdapter dap = new SqlDataAdapter();

        public void connecter()
        {
            if(cnx.State == ConnectionState.Broken || cnx.State == ConnectionState.Closed)
            {
                cnx.ConnectionString = "Data Source=DESKTOP-RKVCGVV;Initial Catalog=efmbchir;Integrated Security=True";
                cnx.Open();
            }
        }
        public void deconnecter()
        {
            if(cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
    }
}
