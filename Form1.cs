using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptor_V00A2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadingScreen.Location = new System.Drawing.Point(421,0);
            delay.Start();
        }

        private void button1_hover(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::Encryptor_V00A2.Properties.Resources.HoverReadyBtn;
        }

        
       
    }
}
