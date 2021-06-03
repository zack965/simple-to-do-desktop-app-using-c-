using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace efmbchir
{
    public partial class Missions : Form
    {
        string username;
        public Missions()
        {
            InitializeComponent();
            username = Login.username;
        }
        ADO d = new ADO();
        public static int Index = 0;
        public void RemplirGrid()
        {
            d.connecter();
            d.cmd.CommandText = "select * from missions";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dataGridView1.DataSource = d.dt;
            d.dr.Close();
        }
        public void RemplirCombobox()
        {
            
            d.cmd.CommandText = "select * from difficulty";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            //d.dt.Load(d.dr);
            while (d.dr.Read())
            {
                comboBox1.Items.Add(d.dr[1].ToString());
            }
            //comboBox1.DataSource = d.dt;
            d.dr.Close();
            
        }
        //zakaria@gmail.com
        private void Missions_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username))
            {
                username = "2";
            }
            //MessageBox.Show(username.ToString());
            
            RemplirGrid();
            RemplirCombobox();
            Naviger(Index);
            UpdateFieldsToIndex(Index);
            this.dataGridView1.Columns["mission_name"].Frozen = true;
        }
        public void GetIdDifficultyMission()
        {
            int selectedindex = comboBox1.SelectedIndex + 1;
            MessageBox.Show(selectedindex.ToString());
        }
        public void add_mission()
        {
            int selectedindex = comboBox1.SelectedIndex + 1;
            d.cmd.CommandText = "insert into missions values (@id_user,@mission_name,@mission_description,@mission_date_time,@mission_id_difficulty)";
            d.cmd.Connection = d.cnx;
            d.cmd.Parameters.AddWithValue("@id_user", username);
            d.cmd.Parameters.AddWithValue("@mission_name", mission_name.Text);
            d.cmd.Parameters.AddWithValue("@mission_description", mission_description.Text);
            d.cmd.Parameters.AddWithValue("@mission_date_time", mission_date_time.Value.ToShortDateString());
            d.cmd.Parameters.AddWithValue("@mission_id_difficulty", selectedindex.ToString());
            d.cmd.ExecuteNonQuery();
        }
        public void ClearGrid()
        {
            d.dt.Clear();
            dataGridView1.DataSource = d.dt;
        }
        private void btn_add_mission_Click(object sender, EventArgs e)
        {
            //GetIdDifficultyMission();
            ClearGrid();
            add_mission();
            RemplirGrid();
        }
        public void Naviger(int Index)
        {
            //int currentindex = dataGridView1.SelectedRows.Count - 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }
            dataGridView1.Rows[Index].Selected = true;


        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            Index = 0;
            Naviger(Index);
            UpdateFieldsToIndex(Index);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Index++;
            Naviger(Index);
            UpdateFieldsToIndex(Index);
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            Index--;
            Naviger(Index);
            UpdateFieldsToIndex(Index);
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            Index = dataGridView1.Rows.Count - 2;
            //MessageBox.Show(cpt.ToString());
            Naviger(Index);
            UpdateFieldsToIndex(Index);
        }
        public void Delete(int Index)
        {
            d.cmd.CommandText = "delete from missions where mission_id = @id_mission_delete";
            d.cmd.Connection = d.cnx;
            d.cmd.Parameters.AddWithValue("@id_mission_delete", dataGridView1.Rows[Index].Cells[0].Value);
            d.cmd.ExecuteNonQuery();
        }
        private void btn_missimn_delete_Click(object sender, EventArgs e)
        {
            Delete(Index);
            ClearGrid();
            RemplirGrid();
        }
       
        public void UpdateFieldsToIndex(int Index)
        {
            mission_name.Text = dataGridView1.Rows[Index].Cells[2].Value.ToString();
            mission_description.Text = dataGridView1.Rows[Index].Cells[3].Value.ToString();
            mission_date_time.Value = Convert.ToDateTime(dataGridView1.Rows[Index].Cells[4].Value);
            comboBox1.SelectedIndex = Convert.ToInt16(dataGridView1.Rows[Index].Cells[5].Value)-1;
        }
        public void Update_Mission(int Index)
        {
            int selectedindex = comboBox1.SelectedIndex + 1;
            string mission_id = dataGridView1.Rows[Index].Cells[0].Value.ToString();
            
            d.cmd.CommandText = "UPDATE missions SET mission_name = @mission_name, mission_description = @mission_description, mission_date_time = @mission_date_time ,mission_id_difficulty = @mission_id_difficulty WHERE mission_id = @mission_id";
            d.cmd.Connection = d.cnx;
            d.cmd.Parameters.AddWithValue("@mission_name", mission_name.Text);
            //MessageBox.Show(mission_name.Text);
            d.cmd.Parameters.AddWithValue("@mission_description", mission_description.Text);
            //MessageBox.Show(mission_description.Text);
            d.cmd.Parameters.AddWithValue("@mission_date_time", mission_date_time.Value.ToShortDateString());
            //MessageBox.Show(mission_date_time.Value.ToShortDateString());
            d.cmd.Parameters.AddWithValue("@mission_id_difficulty", selectedindex.ToString());
            //MessageBox.Show(selectedindex.ToString());
            d.cmd.Parameters.AddWithValue("@mission_id", mission_id);
            //MessageBox.Show(mission_id);
            d.cmd.ExecuteNonQuery();
        }
        private void btn_update_mission_Click(object sender, EventArgs e)
        {

            Update_Mission(Index);
            ClearGrid();
            RemplirGrid();
        }
        public void ExporterText()
        {
            d.cmd.CommandText = "select * from missions";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            if(MessageBox.Show("voulez-vous entrez vos donne ","confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string chemin = "";
                    saveFileDialog1.Filter = "Text Files | .*txt";
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        chemin = saveFileDialog1.FileName;
                    }
                    StreamWriter st = new StreamWriter(chemin);
                    for (int i = 0; i < d.dt.Rows.Count; i++)
                    {
                        st.WriteLine(d.dt.Rows[i][0].ToString() + " " + d.dt.Rows[i][2].ToString());
                    }
                    st.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("vous avez un erreur" + e.ToString());
                }
            }
        }public void ExporterWord()
        {
            d.cmd.CommandText = "select * from missions";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            if(MessageBox.Show("voulez-vous entrez vos donne ","confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string chemin = "";
                    //saveFileDialog1.Filter = "Word Files | .*doc";
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        chemin = saveFileDialog1.FileName;
                    }
                    StreamWriter st = new StreamWriter(chemin);
                    for (int i = 0; i < d.dt.Rows.Count; i++)
                    {
                        st.WriteLine(d.dt.Rows[i][0].ToString() + " " + d.dt.Rows[i][2].ToString());
                    }
                    st.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("vous avez un erreur" + e.ToString());
                }
            }
        }
        private void btn_test_file_Click(object sender, EventArgs e)
        {
            ExporterText();
        }
        public DataSet dsxml = new DataSet();
        public void ExporterXml()
        {
            d.cmd.CommandText = "select * from missions";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            //d.dt.Load(d.dr);
            dsxml.Tables.Add("missions");
            dsxml.Tables["missions"].Load(d.dr);
            string cheminxml = "";
            saveFileDialog2.Filter = "XML FILES | .*xml";
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                cheminxml = saveFileDialog2.FileName;
            }
            dsxml.WriteXml(cheminxml);

        }
        private void btn_xml_Click(object sender, EventArgs e)
        {
            ExporterXml();
        }
        public void Dtext()
        {
            ofd.ShowDialog();
            txtfilepath.Text = ofd.FileName;
            txtfilename.Text = Path.GetFileName(ofd.FileName);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dtext();
        }
        public void vider()
        {
            d.dt.Clear();
            dataGridView1.DataSource = d.dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vider();
        }
        
        public void Charger_DG()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var missions = from m in dc.missions
                           select new
                           {
                               m.mission_description
                           };
            dataGridView1.DataSource = missions;
        }
        private void linqSqlCharger_Click(object sender, EventArgs e)
        {
            Charger_DG();
        }

        private void word_Click(object sender, EventArgs e)
        {
            //ExporterWord();
        }
    }
}
