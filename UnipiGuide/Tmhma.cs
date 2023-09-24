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
                    richTextBox1.Text = "Οι απόφοιτοί μας απολαμβάνουν τη φήμη ενός καλού πανεπιστημίου όταν βγαίνουν στην αγορά \nεργασίας, γεγονός που αναγνωρίζεται και μέσα από διεθνείς αξιολογήσεις. \nΣυγκεκριμένα, το τμήμα μας είναι ένα από τα δύο τμήματα στην Ελλάδα που περιλαμβάνονται \nστη λίστα Academic Ranking of World Universities (ARWU) (γνωστή και ως Shanghai Ranking)\nως ένα από τα καλύτερα Τμήματα Οικονομικής Επιστήμης παγκοσμίως (στη θέση 200-300). \nΑυτό έχει ως συνέπεια οι απόφοιτοί μας να υπηρετούν σε υψηλές θέσεις στον ιδιωτικό και\nδημόσιο τομέα της χώρας μας, καθώς και σε καταξιωμένα πανεπιστήμια του εξωτερικού.";
                    break;
                case "statistics":
                    richTextBox1.Text = "Σκοπός το Τμήματος είναι η θεωρητική εκπαίδευση και η πρακτική κατάρτιση των φοιτητών \nστα γνωστικά πεδία της Στατιστικής και Ασφαλιστικής Επιστήμης. Το πρόγραμμα σπουδών του Τμήματος,\n πέραν των απαραίτητων μαθημάτων υποδομής και των μαθημάτων γενικού ενδιαφέροντος, \nαποτελείται από μία συστηματική σύνθεση μαθημάτων από θεωρητικά και εφαρμοσμένα \nγνωστικά αντικείμενα των επιστημονικών αυτών κλάδων. Οι φοιτητές του Τμήματος έχουν \nτη δυνατότητα απόκτησης ειδικότητας σε στατιστικά ή ασφαλιστικά θέματα,\nμε παράλληλη απόκτηση σχετικών γνώσεων Εφαρμοσμένης Πληροφορικής.";
                    break;
                case "shipping":
                    richTextBox1.Text = "Έχοντας ως βάση το παγκόσμιας εμβέλειας και ακτινοβολίας ναυτιλιακό κέντρο του Πειραιά, \nτη ναυτιλιακή πρωτεύουσα που φιλοξενεί τη μεγαλύτερη ναυτιλία του κόσμου και \nτο δυναμικότερο ναυτιλιακό cluster της Ευρώπης, το Τμήμα Ναυτιλιακών Σπουδών είναι σε θέση \nνα συνδέεται στενά και να βρίσκεται σε σχέση αλληλοϋποστήριξης με τους φορείς και \nτους οργανισμούς της ναυτιλίας. Έχει έτσι τη δυνατότητα να αντλεί πρακτικές γνώσεις και να \nπροσαρμόζει τα προγράμματά του ώστε να υποστηρίζουν τις παραγωγικές ανάγκες της ναυτιλίας \nκαι των μεταφορών.";
                    break;
                case "informatics":
                    richTextBox1.Text = "Οι βασικοί άξονες του Τμήματος είναι η εκπαίδευση και η έρευνα. Η εκπαίδευση, παρέχεται \nσε 3 επίπεδα. Στο πρώτο επίπεδο παρέχονται οι προπτυχιακές σπουδές με την εισαγωγή φοιτητών \nαπό τις Πανελλαδικές εξετάσεις της χώρας που οδηγούν στην απόκτηση Πτυχίου Πληροφορικής. \nΣτο δεύτερο επίπεδο παρέχονται μεταπτυχιακές σπουδές που οδηγούν στην απόκτηση \nΜεταπτυχιακού Διπλώματος Ειδίκευσης και στο τρίτο επίπεδο παρέχονται διδακτορικές \nσπουδές που οδηγούν στην απόκτηση διδακτορικού διπλώματος.";
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
