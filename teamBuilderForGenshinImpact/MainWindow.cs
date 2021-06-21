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

            //To initialize the list view
            this.initializeListView();
        }


        //A method which initialize the list view with the data in the database
        public void initializeListView()
        {
            this.charactersList.Clear();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_characters", this.cn);                        
            using MySqlDataReader Read = cmd.ExecuteReader();
            while (Read.Read())
            {
                String c_name = Read["c_name"].ToString();
                String c_vision = Read["c_vision"].ToString();
                String c_rarity = Read["c_rarity"].ToString();
                String c_weapon = Read["c_weapon"].ToString();

                this.charactersList.Items.Add(new ListViewItem(new[] { c_name, c_vision, c_rarity, c_weapon }));
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
