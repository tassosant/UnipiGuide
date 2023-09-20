using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using UnipiGuide.Models;

namespace UnipiGuide
{
    
    public partial class Home : Form
    {
<<<<<<< HEAD
        private System.Windows.Forms.MenuStrip menuStrip;
        FormForNavBar formForNavBar;
=======
        int imgNum = 1;
        FolderBrowserDialog fbd;
>>>>>>> c7f565983a579ad776dd9d07b4ce3adca04c612b
        public Home(bool isUser, User user)
        {
            InitializeComponent();
            InitializeCustomMenuStrip();


            this.formForNavBar = new FormForNavBar();
            this.menuStrip = this.formForNavBar.GetMenuStrip();
            this.MainMenuStrip = this.menuStrip;
            this.formForNavBar.LayoutsAndControlsHandler(this.menuStrip, this);
            if (!isUser)
            {
                // this is the eclass button, accessible only for registered users
                button_WOC2.Hide();
            }

        }


        // schools button
        private void button_WOC2_Click(object sender, EventArgs e)
        {
            NavigateToForm(new Schools());
            //Schools h = new Schools();
            //h.ShowDialog();
        }

        // review button
        private void button_WOC3_Click(object sender, EventArgs e)
        {
            NavigateToForm(new ReviewForm());
            //ReviewForm h = new ReviewForm();
            //h.ShowDialog();
        }

        // eclass button
        private void button_WOC2_Click_1(object sender, EventArgs e)
        {
            NavigateToForm(new EClass());
            //EClass h = new EClass();
            //h.ShowDialog();
        }

        private void NavigateToForm(Form form)
        {

            form.Tag = this;
            form.Show(this);
            Hide();
        }
<<<<<<< HEAD
        
            
        private void InitializeCustomMenuStrip()
        {
            //this.menuStrip.SuspendLayout();
            //this.SuspendLayout();
            //this.MainMenuStrip = this.menuStrip;
            //this.Controls.Add(this.menuStrip);
            //this.ResumeLayout(false);
            //this.PerformLayout();
=======

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

>>>>>>> c7f565983a579ad776dd9d07b4ce3adca04c612b

        }
    }
}