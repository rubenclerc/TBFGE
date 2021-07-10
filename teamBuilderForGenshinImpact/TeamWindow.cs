using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

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
    }
}
