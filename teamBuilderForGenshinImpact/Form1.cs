using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teamBuilderForGenshinImpact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Initialisation
        MySqlConnection cn;
        bool isConnected = false;

        //To connect to DB
        private void connectButton_Click(object sender, EventArgs e)
        {

            //If the text is equal to Connect to DB, then we connect us to it
            if (connect.Text.Equals("Connect to DB"))
            {
                cn = new MySqlConnection("SERVER=localhost;PORT=3306;DATABASE=tbfge;UID=root;PWD=;");

                try
                {
                    if (cn.State == ConnectionState.Closed) { cn.Open(); }
                    connect.Text = "Unconnect";
                    this.isConnected = true;

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }


            //Else we unconnect us from the DB
            else
            {
                cn.Close();
                connect.Text = "Connect to DB";
                this.isConnected = false;
            }
        }
    }
}
