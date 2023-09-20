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

namespace UnipiGuide
{
    public partial class FormForNavBar : Form
    {
        EClass EClass;
        Home home;
        ReviewForm reviewForm;
        Schools schools;
        public FormForNavBar()
        {
            InitializeComponent();
            InitializeProperties();
            InitializeClicks();
        }

        public System.Windows.Forms.MenuStrip GetMenuStrip()
        {
            return this.menuStrip;
        }

        public void LayoutsAndControlsHandler(MenuStrip menuStrip, Form form)
        {
            menuStrip.SuspendLayout();
            form.SuspendLayout();
            form.MainMenuStrip = this.menuStrip;
            form.Controls.Add(this.menuStrip);
            form.ResumeLayout(false);
            form.PerformLayout();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.home = new Home(MockDB.isUser, MockDB.SelectedUser);
            this.Close();
        }

        private void InitializeProperties()
        {
            
            

        }

        private void InitializeClicks()
        {

        }

        private void SchoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.schools = new Schools();
            this.Close();
        }

        private void NavigateToForm(Form form)
        {
            form.Tag = this;
            form.Show(this);
            this.Close();
        }
    }
}
