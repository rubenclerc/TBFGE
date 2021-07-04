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

        //A method to close the application
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            //Read selected items and add them in a new listview
            foreach(ListViewItem item in this.list.SelectedItems)
            {
                //Test if the character is already in the list view
                try
                {
                    this.validateCharacter(item.SubItems[0].Text);

                    //Read data
                    String name = item.SubItems[0].Text;
                    String vision = item.SubItems[1].Text;
                    String rarity = item.SubItems[2].Text;
                    String weapon = item.SubItems[3].Text;

                    //Add character into the list view
                    this.charactList.Items.Add(new ListViewItem(new[] { name, vision, rarity, weapon }));
                }
                catch(LogicError ex)
                {
                    ex.ToString();
                }
            }
                      

        }


        //To create a new team
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Exceptions management
                this.validateListView();
                this.validateResonance();



                

            }catch(LogicError ex)
            {
                ex.ToString();
            }


        }

        //To validate the characters list view
        private void validateListView()
        {
            
            if (this.charactList.Items.Count < 4)
            {
                throw new NotEnoughCharactersError();
            }
        }


        //To delete a character
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Read selected items and delete them
            foreach (ListViewItem item in this.charactList.SelectedItems)
            {
                item.Remove();
            }
        }

        //To validate a character
        private void validateCharacter(string characterName)
        {

            foreach(ListViewItem item in this.charactList.Items)
            {
                if (characterName.Equals(item.SubItems[0].Text))
                {
                    throw new ExistingCharacterError();
                }
            }
        }

        //To validate reseonance
        private void validateResonance()
        {
            if((this.resonanceCheckBox.CheckedItems.Count == 0) || (this.resonanceCheckBox.CheckedItems.Count == 3) || (this.resonanceCheckBox.CheckedItems.Count > 4))
            {
                throw new ResonanceError();
            }
        }
    }
}
