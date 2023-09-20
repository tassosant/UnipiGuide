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
    public partial class EClass : Form
    {
        public EClass()
        {
            InitializeComponent();
            this.monthCalendar1.BoldedDates = new System.DateTime[] { new System.DateTime(2023, 9, 18, 0, 0, 0, 0) };
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.textBox1.Text =
              monthCalendar1.SelectionRange.Start.Date.ToShortDateString();          
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "Δεν έχεις πολύ χρόνο!";
              
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
