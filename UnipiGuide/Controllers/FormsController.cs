using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiGuide.Controllers
{
    public static class FormsController
    {
        private static Dictionary<Type, Form> openForms = new Dictionary<Type, Form>();
        

        //public static void ShowForm<T>() where T : Form, new()
        //{
        //    Type formType = typeof(T);

        //    //if dictionary does not have instantiated form, then add it and create an instance of the form
        //    if (!openForms.ContainsKey(formType) || openForms[formType].IsDisposed)
        //    {
        //        openForms[formType] = new T();
        //        openForms[formType].FormClosed += (sender, e) => openForms.Remove(formType);
        //    }

        //    openForms[formType].Show();
        //    openForms[formType].BringToFront();
        //}

        public static void ShowForm(Type formType)
        { 
            

            //if dictionary does not have instantiated form, then add it and create an instance of the form
            if (!openForms.ContainsKey(formType) || openForms[formType].IsDisposed)
            {
                Form form = (Form)Activator.CreateInstance(formType);
                openForms.Add(formType, form);
                //openForms[formType].FormClosed += (sender, e) => openForms.Remove(formType);
                openForms[(formType)].Disposed += (sender, e) => openForms.Remove(formType);

            }
            

            openForms[formType].Show();
            openForms[formType].BringToFront();
            
        }
    }
}
