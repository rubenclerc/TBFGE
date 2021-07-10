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
            //Reset the data in the c_team table
            MySqlCommand resetCommand = new MySqlCommand("TRUNCATE t_team", this.cn);
            resetCommand.ExecuteNonQuery();

            //Close the app
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
                    String vision = null;
                    String weapon = null;
                    String main = null;
                    String burst = null;
                    String support = null;
                    String heal = null;

                    MySqlCommand charCommand = new MySqlCommand("SELECT * FROM t_characters WHERE c_name = @name", this.cn);
                    charCommand.Parameters.AddWithValue("@name", name);

                    using (MySqlDataReader Lire = charCommand.ExecuteReader())
                    {
                        while (Lire.Read())
                        {
                            vision = Lire["c_vision"].ToString();
                            weapon = Lire["c_weapon"].ToString();
                            main = Lire["c_main"].ToString();
                            burst = Lire["c_burst"].ToString();
                            support = Lire["c_support"].ToString();
                            heal = Lire["c_heal"].ToString();
                        }
                    }


                    //Add the character into the listview
                    this.charactList.Items.Add(new ListViewItem(new[] { name }));

                    //Add the character into the temporary table
                    MySqlCommand addCommand = new MySqlCommand("INSERT INTO t_team VALUES (@name, @vision, @weapon, @main, @burst, @support, @heal)", this.cn);
                    addCommand.Parameters.AddWithValue("@name", name);
                    addCommand.Parameters.AddWithValue("@vision", vision);
                    addCommand.Parameters.AddWithValue("@weapon", weapon);
                    addCommand.Parameters.AddWithValue("@main", int.Parse(main));
                    addCommand.Parameters.AddWithValue("@burst", int.Parse(burst));
                    addCommand.Parameters.AddWithValue("@support", int.Parse(support));
                    addCommand.Parameters.AddWithValue("@heal", Convert.ToBoolean(heal));

                    addCommand.ExecuteNonQuery();
                    addCommand.Parameters.Clear();
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
                //Remove the character from the temporary table
                MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM t_team WHERE c_name = @name", this.cn);
                deleteCommand.Parameters.AddWithValue("@name", item.SubItems[0].Text);
                deleteCommand.ExecuteNonQuery();

                //Remove the character from the listview
                item.Remove();
            }
        }



        //Team creation:

        //To create a new team
        private void createButton_Click(object sender, EventArgs e)
        {

            int nbRes = this.resonanceCheckBox.CheckedItems.Count;
            IDictionary<string, string> teamList = null;

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
        public IDictionary<string, string> oneItemResonance()
        {
            IDictionary<string, string> res = new Dictionary<string, string>();

            return res;
        }

        public IDictionary<string, string> twoItemsResonance()
        {
            IDictionary<string, string> res = new Dictionary<string, string>();

            return res;
        }

        public IDictionary<string, string> fourItemsResonance()
        {
            IDictionary<string, string> res = new Dictionary<string, string>();

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
