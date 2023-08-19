using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnipiGuide
{
    public partial class Tmhma : Form
    {
       
        public Tmhma(string department)
        {
            InitializeComponent();
            // initialize text box
            switch (department) {
                case "economics":
                    richTextBox1.Text = "economics";
                    break;
                case "statistics":
                    richTextBox1.Text = "statistics";
                    break;
                case "shipping":
                    richTextBox1.Text = "shipping";
                    break;
                case "informatics":
                    richTextBox1.Text = "informatics";
                    break;
            }
            
            
        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.richTextBox1.Text, this.richTextBox1.Font, Brushes.Black, 10, 25);
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            // print window "Σχολή Οικονομικών, Επιχειρηματικών και Διεθνών Σπουδών"
           
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
            printDocument.Print();

        }
    }
}
