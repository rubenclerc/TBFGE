using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace teamBuilderForGenshinImpact
{
    public partial class MainWindow : Form
    {

        public MainWindow(Boolean isCon)
        {
            InitializeComponent();
            this.lb.Text = isCon.ToString();
        }

    }
}
