using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teamBuilderForGenshinImpact
{
    public partial class MainWindow : Form
    {

        private MySqlConnection cn;

        public MainWindow(MySqlConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
            this.isCon.Text = this.cn.ConnectionString;

            //To initialize the list view
            this.initializeListView();
        }


        //A method which initialize the list view with the data in the database
        public void initializeListView()
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_characters", this.cn);
            using (MySqlDataReader Lire = cmd.ExecuteReader())
            {
                while (Lire.Read())
                {
                    String name = Lire["c_name"].ToString();
                    String vision = Lire["c_vision"].ToString();
                    String rarity = Lire["c_rarity"].ToString();
                    String weapon = Lire["c_weapon"].ToString();

                    this.list.Items.Add(new ListViewItem(new[] { name, vision, rarity, weapon }));
                }
            }

        }

        //A method to refresh the list view
        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.initializeListView();
        }

        //A method to close the application
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
