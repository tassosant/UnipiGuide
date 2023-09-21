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

        }

        private void MakeMenuItemsVisible()
        {
            foreach(ToolStripMenuItem item in this.menuItems.Keys)
            {
                item.Visible = true;
                this.Items.Add(item);
            }
        }

        private void GoToForm(Form form)
        {

            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void NavigateToForm(Form form)
        {
            form.Tag = this;
            form.Show(this);

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
            Type currentFormType = this.Parent.GetType();
            Type formTypeToNavigate = formType;

            if(formTypeToNavigate!= currentFormType) {             
                Form form = (Form)Activator.CreateInstance(formType);
                form.Show();
            }

        }
    }
}
