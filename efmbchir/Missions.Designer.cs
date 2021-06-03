
namespace efmbchir
{
    partial class Missions
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mission_name = new System.Windows.Forms.TextBox();
            this.mission_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mission_date_time = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add_mission = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_missimn_delete = new System.Windows.Forms.Button();
            this.btn_update_mission = new System.Windows.Forms.Button();
            this.btn_test_file = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_xml = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfilepath = new System.Windows.Forms.TextBox();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.linqSqlCharger = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(906, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "mission name";
            // 
            // mission_name
            // 
            this.mission_name.Location = new System.Drawing.Point(147, 13);
            this.mission_name.Name = "mission_name";
            this.mission_name.Size = new System.Drawing.Size(100, 22);
            this.mission_name.TabIndex = 3;
            // 
            // mission_description
            // 
            this.mission_description.Location = new System.Drawing.Point(146, 68);
            this.mission_description.Name = "mission_description";
            this.mission_description.Size = new System.Drawing.Size(100, 22);
            this.mission_description.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "mission description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // mission_date_time
            // 
            this.mission_date_time.Location = new System.Drawing.Point(147, 127);
            this.mission_date_time.Name = "mission_date_time";
            this.mission_date_time.Size = new System.Drawing.Size(200, 22);
            this.mission_date_time.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 187);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mission Difficulty";
            // 
            // btn_add_mission
            // 
            this.btn_add_mission.Location = new System.Drawing.Point(16, 253);
            this.btn_add_mission.Name = "btn_add_mission";
            this.btn_add_mission.Size = new System.Drawing.Size(124, 37);
            this.btn_add_mission.TabIndex = 9;
            this.btn_add_mission.Text = "Ajouter Mission";
            this.btn_add_mission.UseVisualStyleBackColor = true;
            this.btn_add_mission.Click += new System.EventHandler(this.btn_add_mission_Click);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(16, 310);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(109, 38);
            this.btn_first.TabIndex = 10;
            this.btn_first.Text = "Premier";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(216, 310);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(109, 38);
            this.btn_next.TabIndex = 11;
            this.btn_next.Text = "Suivant";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(436, 310);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(109, 38);
            this.btn_previous.TabIndex = 12;
            this.btn_previous.Text = "Precedant";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(551, 310);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(109, 38);
            this.btn_last.TabIndex = 13;
            this.btn_last.Text = "Dernier";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_missimn_delete
            // 
            this.btn_missimn_delete.Location = new System.Drawing.Point(216, 253);
            this.btn_missimn_delete.Name = "btn_missimn_delete";
            this.btn_missimn_delete.Size = new System.Drawing.Size(174, 37);
            this.btn_missimn_delete.TabIndex = 14;
            this.btn_missimn_delete.Text = "Supprimer Mission";
            this.btn_missimn_delete.UseVisualStyleBackColor = true;
            this.btn_missimn_delete.Click += new System.EventHandler(this.btn_missimn_delete_Click);
            // 
            // btn_update_mission
            // 
            this.btn_update_mission.Location = new System.Drawing.Point(436, 253);
            this.btn_update_mission.Name = "btn_update_mission";
            this.btn_update_mission.Size = new System.Drawing.Size(174, 37);
            this.btn_update_mission.TabIndex = 15;
            this.btn_update_mission.Text = "Modifier Mission";
            this.btn_update_mission.UseVisualStyleBackColor = true;
            this.btn_update_mission.Click += new System.EventHandler(this.btn_update_mission_Click);
            // 
            // btn_test_file
            // 
            this.btn_test_file.Location = new System.Drawing.Point(617, 253);
            this.btn_test_file.Name = "btn_test_file";
            this.btn_test_file.Size = new System.Drawing.Size(174, 37);
            this.btn_test_file.TabIndex = 16;
            this.btn_test_file.Text = "Exporter via text file";
            this.btn_test_file.UseVisualStyleBackColor = true;
            this.btn_test_file.Click += new System.EventHandler(this.btn_test_file_Click);
            // 
            // btn_xml
            // 
            this.btn_xml.Location = new System.Drawing.Point(666, 311);
            this.btn_xml.Name = "btn_xml";
            this.btn_xml.Size = new System.Drawing.Size(174, 37);
            this.btn_xml.TabIndex = 17;
            this.btn_xml.Text = "Exporter via xml file";
            this.btn_xml.UseVisualStyleBackColor = true;
            this.btn_xml.Click += new System.EventHandler(this.btn_xml_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "D Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "file path";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "file name";
            // 
            // txtfilepath
            // 
            this.txtfilepath.Location = new System.Drawing.Point(135, 381);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Size = new System.Drawing.Size(100, 22);
            this.txtfilepath.TabIndex = 21;
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(135, 428);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(100, 22);
            this.txtfilename.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 38);
            this.button2.TabIndex = 23;
            this.button2.Text = "Vider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linqSqlCharger
            // 
            this.linqSqlCharger.Location = new System.Drawing.Point(630, 381);
            this.linqSqlCharger.Name = "linqSqlCharger";
            this.linqSqlCharger.Size = new System.Drawing.Size(182, 54);
            this.linqSqlCharger.TabIndex = 24;
            this.linqSqlCharger.Text = "Linq To Sql Charger";
            this.linqSqlCharger.UseVisualStyleBackColor = true;
            this.linqSqlCharger.Click += new System.EventHandler(this.linqSqlCharger_Click);
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(846, 253);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(174, 37);
            this.word.TabIndex = 25;
            this.word.Text = "Exporter via word file";
            this.word.UseVisualStyleBackColor = true;
            this.word.Click += new System.EventHandler(this.word_Click);
            // 
            // Missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 481);
            this.Controls.Add(this.word);
            this.Controls.Add(this.linqSqlCharger);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.txtfilepath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_xml);
            this.Controls.Add(this.btn_test_file);
            this.Controls.Add(this.btn_update_mission);
            this.Controls.Add(this.btn_missimn_delete);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_add_mission);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mission_date_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mission_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mission_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Missions";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Missions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mission_name;
        private System.Windows.Forms.TextBox mission_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker mission_date_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add_mission;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_missimn_delete;
        private System.Windows.Forms.Button btn_update_mission;
        private System.Windows.Forms.Button btn_test_file;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_xml;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfilepath;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button linqSqlCharger;
        private System.Windows.Forms.Button word;
    }
}

