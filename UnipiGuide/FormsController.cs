using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiGuide
{
    internal static class FormsController
    {
        private static Dictionary<Type, Form> openForms = new Dictionary<Type, Form>();

        public static void ShowForm<T>() where T : Form, new()
        {
            Type formType = typeof(T);

            if (!openForms.ContainsKey(formType) || openForms[formType].IsDisposed)
            {
                openForms[formType] = new T();
                openForms[formType].FormClosed += (sender, e) => openForms.Remove(formType);
            }

            openForms[formType].Show();
            openForms[formType].BringToFront();
        }
    }
}
