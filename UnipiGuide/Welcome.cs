﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnipiGuide.Controllers;
using UnipiGuide.Models;

namespace UnipiGuide
{
    public partial class Welcome : Form
    {
        /*MockUsers mockUsers;*/
        MockDB db;
        ArrayList users;
        
        public Welcome()
        {
            InitializeComponent();
            InitWelcomeFormsModels();
            AddEvents();
        }

        private void InitWelcomeFormsModels()
        {
            /*this.mockUsers = new MockUsers();
            this.users = new ArrayList();
            this.users = this.mockUsers.Users;*/
            this.db = new MockDB(); //create the users
            this.users = new ArrayList();
            this.users = MockDB.Users;
        }              

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // continue as user button
        private void login_button_WOC1_Click(object sender, EventArgs e)
        {
            
            
            bool isUser = true;
            User user = null;
            // TODO code to validate user
            if ((user = ValidateUser()) == null)
            {
                isUser = false;
                this.ErrorLoginMessageLabel.Text = "Wrong username or password";
            }
            else
            {
                //this.db.SelectedUser = user;
                MockDB.SelectedUser = user;
                this.ErrorLoginMessageLabel.Text = string.Empty;
                //Home h = new Home(isUser, this.db.SelectedUser);
                NavigateToForm(isUser, MockDB.SelectedUser);
                //Home h = new Home(isUser, MockDB.SelectedUser);
                //h.ShowDialog();
            }
        }

        private User ValidateUser()
        {
            string username = this.UsernameTextBox.Text;
            string password = this.PasswordTextBox.Text;
            foreach(User user in this.users)
            {
                if (username.Equals(user.UserName) && password.Equals(user.Password))
                {
                    return user;
                }
            }
            return null;
        }

        private void PasswordTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // continue as guest button
        private void guest_button_WOC2_Click(object sender, EventArgs e)
        {
            bool isUser = false;
            NavigateToForm(isUser, null);
            //Home h = new Home(isUser, null); 
            //h.ShowDialog();
            
             
        }

        private void NavigateToForm(bool isUser, User user)
        {
            
                //Home h = new Home(isUser, user);
                //h.ShowDialog();
                Home h = new Home(isUser, user);
                h.Tag = this;
                h.Show(this);
                Hide();
        }

        private void AddEvents()
        {
            AddCloseEvent();
        }

        private void AddCloseEvent()
        {
            this.SuspendLayout();
            this.FormClosing += Form_Closing;
            this.ResumeLayout(false);
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                Application.Exit();
            }
        }
    }
}
