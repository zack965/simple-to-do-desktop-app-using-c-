using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace efmbchir
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        public static string username = string.Empty;
        private void Connect_Click(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select user_id from users where user_email=@email and user_password=@password";
            d.cmd.Parameters.AddWithValue("@email", txtuseremail.Text);
            d.cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            foreach (DataRow dataRow in d.dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    //Console.WriteLine(item);
                    res.Text = item.ToString();
                }
            }
            username = res.Text;
            if(username == string.Empty)
            {
                MessageBox.Show("something is wrong");
            }
            else
            {
                this.Hide();
                Missions miss = new Missions();
                miss.Show();
            }
        }
    }
}
