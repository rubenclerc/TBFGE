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
    public partial class startWindow : Form
    {

        //Initialisation
        private MySqlConnection cn;

        public startWindow()
        {
            InitializeComponent();
        }

        //To connect to DB and show the main window
        private void connect_Click(object sender, EventArgs e)
        {
            

            //Connection String
            cn = new MySqlConnection("SERVER=localhost;PORT=3306;DATABASE=tbfge;UID=root;PWD=;");

            //Connection to the DB
            try
            {
                if (cn.State == ConnectionState.Closed) { cn.Open(); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            //To instantiate and show the main window
            MainWindow mw = new MainWindow(this.cn);
            mw.Show();
            this.Hide();
        }
    }
}
