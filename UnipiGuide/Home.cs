using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnipiGuide.Controllers;
using UnipiGuide.DebuggingClass;
using UnipiGuide.Models;

namespace UnipiGuide
{
    public partial class Home : Form
    {
        int imgNum = 1;
        FolderBrowserDialog fbd;
        public Home(bool isUser, User user)
        {
            InitializeComponent();
            
            NavbarItems.PrintOrder(this);
            
            if (!isUser)
            {
                // this is the eclass button, accessible only for registered users
                button_WOC2.Hide();
            }

        }

        public Home()
        {
            InitializeComponent();
            
            if (MockDB.SelectedUser == null)
            {
                button_WOC2.Hide();
            }
        }


        // schools button
        private void button_WOC2_Click(object sender, EventArgs e)
        {
            //NavigateToForm(new Schools());
            Controllers.FormsController.ShowForm(typeof(Schools));
            this.Dispose(true);
            //Schools h = new Schools();
            //h.ShowDialog();
        }

        // review button
        private void button_WOC3_Click(object sender, EventArgs e)
        {
            Controllers.FormsController.ShowForm(typeof(ReviewForm));
            this.Dispose(true);
            //NavigateToForm(new ReviewForm());
            //ReviewForm h = new ReviewForm();
            //h.ShowDialog();
        }

        // eclass button
        private void button_WOC2_Click_1(object sender, EventArgs e)
        {
            Controllers.FormsController.ShowForm(typeof(EClass));
            this.Dispose(true);
            //NavigateToForm(new EClass());
            //EClass h = new EClass();
            //h.ShowDialog();
        }

        private void NavigateToForm(Form form)
        {

            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

        private void LoadNextImage() {
            if (imgNum == 4)
            {
                imgNum = 1;
            }
            pictureBox2.ImageLocation = string.Format(@"Slide\papei{0}.jpg", imgNum);
            imgNum++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();


        }
    }
}
