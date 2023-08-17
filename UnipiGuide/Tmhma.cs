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
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        public Tmhma()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 20, 20);
        }
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            // print window "Σχολή Οικονομικών, Επιχειρηματικών και Διεθνών Σπουδών"
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }


        }
    }
}
