﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnipiGuide.Models;

namespace UnipiGuide
{
    public partial class Home : Form
    {
        public Home(bool isUser, User user)
        {
            InitializeComponent();
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
    }
}
