using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using UnipiGuide.Controllers;

namespace UnipiGuide
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.MenuStrip)]
    public partial class Navbar : System.Windows.Forms.MenuStrip
    {
        private Hashtable menuItems;
        public Navbar()
        {
            InitializeComponent();
            CollectMenuItems();
            MakeMenuItemsVisible();
            AddEventsInMenuItems();
            
        }

        public Navbar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            CollectMenuItems();
            MakeMenuItemsVisible();
            AddEventsInMenuItems();
        }

        private void CollectMenuItems()
        {
            this.menuItems = new Hashtable();
            this.menuItems.Add(this.homeMenuItem, typeof(Home));
            this.menuItems.Add(this.reviewsMenuItem, typeof(ReviewForm));
            this.menuItems.Add(this.schoolsMenuItem, typeof(Schools));
            this.menuItems.Add(this.aboutMenuItem, typeof(MessageBox));

        }

        private void MakeMenuItemsVisible()
        {
            this.SuspendLayout();
            int imageIndex = 0;
            foreach(ToolStripMenuItem item in this.menuItems.Keys)
            {
                
                item.Visible = true;
                item.ImageIndex = imageIndex;                
                //this.Items.Add(item);                
                imageIndex++;

            }
            this.ResumeLayout(false);
        }

        

        private void AddEventsInMenuItems()
        {
            AddClickEvent();
        }

        private void AddClickEvent()
        {
            foreach(ToolStripMenuItem item in this.menuItems.Keys) {
                item.Click += (sender, e) => NavbarItemClicked(sender, e, (Type)this.menuItems[item]);
            }

        }

        private void NavbarItemClicked(object sender, EventArgs e, Type formType)
        {
            //if is about button
            if(formType == typeof(MessageBox)) {
                FillMessageBox();
                return;
            }

            Type currentFormType = this.Parent.GetType();
            Type formTypeToNavigate = formType;

            if(formTypeToNavigate!= currentFormType) {
                //Form form = (Form)Activator.CreateInstance(formType);
                //form.Show();
                FormsController.ShowForm(formTypeToNavigate);
                this.Parent.Dispose();
            }
        }

        private void FillMessageBox()
        {

            string msg = String.Format("Tasos Antoniou\nEuaggelia Thermou");
            string title = "Creators";
            MessageBox.Show(msg, title);
        }
    }
}
