using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiGuide
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // continue as user button
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            // TODO code to validate user
            bool isUser = true;
            Home h = new Home(isUser);
            h.ShowDialog();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // continue as guest button
        private void button_WOC2_Click(object sender, EventArgs e)
        {
            bool isUser = false;
            Home h = new Home(isUser); 
            h.ShowDialog();
            
             
        }
    }
}
