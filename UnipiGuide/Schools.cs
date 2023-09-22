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
            AddEvents();
        }

        private void Schools_Load(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            // school of economics table 
            Tmhma h = new Tmhma("economics");
            h.ShowDialog();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            // sxoli nautilias
            Tmhma h = new Tmhma("shipping");
            h.ShowDialog();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            // sxoli xrimatooikonomikis kai statistikis
            Tmhma h = new Tmhma("statistics");
            h.ShowDialog();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            // sxoli pliroforikis
            Tmhma h = new Tmhma("informatics");
            h.ShowDialog();
        }

        private void AddEvents()
        {
            AddCloseEvent();
        }

        private void AddCloseEvent()
        {
            this.SuspendLayout();
            this.FormClosing += Form_Closing;
            this.ResumeLayout(false);
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                Application.Exit();
            }
        }
    }
}
