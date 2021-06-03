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

namespace efmbchir
{
    public partial class Crystal : Form
    {
        public Crystal()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        private void Crystal_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.dap = new SqlDataAdapter("select * from difficulty",d.cnx);
            DataSet1 ds = new DataSet1();
            d.dap.Fill(ds.difficulty);
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds.Tables["difficulty"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
