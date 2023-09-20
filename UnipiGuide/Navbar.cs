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
        private ArrayList menuItems;
        public Navbar()
        {
            InitializeComponent();
            CollectMenuItems();
            MakeMenuItemsVisible();
        }

        public Navbar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            CollectMenuItems();
            MakeMenuItemsVisible();
        }

        private void CollectMenuItems()
        {
            this.menuItems = new ArrayList();
            this.menuItems.Add(this.toolStripMenuItem1);
            this.menuItems.Add(this.toolStripMenuItem2);
        }

        private void MakeMenuItemsVisible()
        {
            foreach(ToolStripMenuItem item in this.menuItems)
            {
                item.Visible = true;
                this.Items.Add(item);
            }
        }
    }
}
