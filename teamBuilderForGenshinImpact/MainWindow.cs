using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace teamBuilderForGenshinImpact
{
    public partial class MainWindow : Form
    {

        private MySqlConnection cn;

        public MainWindow(MySqlConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
            this.initializeListView();
        }

        //To initialize the list view with the data in the database
        public void initializeListView()
        {
            //SQL Request
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_characters", this.cn);
            using (MySqlDataReader Lire = cmd.ExecuteReader())
            {
                //Reading data
                while (Lire.Read())
                {
                    //Adding data
                    String name = Lire["c_name"].ToString();
                    this.list.Items.Add(new ListViewItem(new[] { name}));
                }
            }

        }

        //To close the application
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            Application.Exit();            
        }



        //Box management:

        //To add a character
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

                    //Add character into the list view
                    this.charactList.Items.Add(new ListViewItem(new[] { name }));
                }
                catch(LogicError ex)
                {
                    ex.ToString();
                }
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



        //Team creation:

        //To create a new team
        private void createButton_Click(object sender, EventArgs e)
        {

            int nbRes = this.resonanceCheckBox.CheckedItems.Count;
            ArrayList teamList = null;

            try
            {
                //Exceptions management
                this.validateListView();
                this.validateResonance();

                //Team creation
                switch (nbRes)
                {
                    case 1:
                        teamList = this.oneItemResonance();
                        break;

                    case 2:
                        teamList = this.twoItemsResonance();
                        break;

                    case 4:
                        teamList = this.fourItemsResonance();
                        break;
                }

                //To display the team
                TeamWindow tw = new TeamWindow(teamList, this.cn);
                this.Hide();
                tw.Show();

            }catch(LogicError ex)
            {
                ex.ToString();
            }
        }

        //Characters selection
        public ArrayList oneItemResonance()
        {
            ArrayList res = new ArrayList();

            return res;
        }

        public ArrayList twoItemsResonance()
        {
            ArrayList res = new ArrayList();

            return res;
        }

        public ArrayList fourItemsResonance()
        {
            ArrayList res = new ArrayList();

            return res;
        }



        //Exceptions:

        //To validate the characters list view
        private void validateListView()
        {

            if (this.charactList.Items.Count < 4)
            {
                throw new NotEnoughCharactersError();
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
