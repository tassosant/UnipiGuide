using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnipiGuide.Models;

namespace UnipiGuide
{
    public partial class Schools : Form
    {
        public Schools()
        {
            InitializeComponent();
        }

        private void Schools_Load(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            // school of economics table 
            Tmhma h = new Tmhma();
            h.ShowDialog();
        }
    }
}
