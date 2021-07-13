using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;
using System.IO;

namespace teamBuilderForGenshinImpact
{
    public partial class TeamWindow : Form
    {
        private IDictionary<string, string> team;
        private MySqlConnection cn;


        public TeamWindow(IDictionary<string, string> team, MySqlConnection cn)
        {
            InitializeComponent();
            this.team = team;
            this.cn = cn;

            //Team initialization
            foreach (String role in this.team.Keys)
            {
                this.newTeamListView.Items.Add(new ListViewItem(new[] { this.team[role].ToString(), role }));
            }

        }

        //To close the application
        private void closeButton_Click(object sender, EventArgs e)
        {
            //Reset the data in the c_team table
            MySqlCommand resetCommand = new MySqlCommand("TRUNCATE t_team", this.cn);
            resetCommand.ExecuteNonQuery();

            //Close the app
            this.cn.Close();
            Application.Exit();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {

            //Initialization
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Title = "Save your team";
            


            //If the user wants to save the team, we write in the file
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, true))
                {
                    //Writing in the file
                    foreach (String role in this.team.Keys)
                    {
                        sw.WriteLine(role + ": " + this.team[role].ToString());                        
                    }

                    sw.Close();
                }
            }           

        }
    }
}
