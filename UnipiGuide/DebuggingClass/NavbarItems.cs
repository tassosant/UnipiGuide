using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiGuide.DebuggingClass
{
    public static class NavbarItems
    {
        public static void PrintOrder(Form form)
        {
            MenuStrip mainMenu = form.MainMenuStrip;
            foreach (ToolStripMenuItem item in mainMenu.Items)
            {
                //Debug.WriteLine(item.Name);
            }
        }

        public static void ChangeOrder(MenuStrip mainMenu)
        {
           
        }
    }
}
