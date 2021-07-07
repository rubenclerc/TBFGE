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
        private ArrayList team;
        private MySqlConnection cn;


        public TeamWindow(ArrayList team, MySqlConnection cn)
        {
            InitializeComponent();
            this.team = team;
            this.cn = cn;
        }

        //To close the application
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            Application.Exit();
        }
    }
}
