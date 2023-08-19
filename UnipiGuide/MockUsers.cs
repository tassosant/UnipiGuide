using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnipiGuide.Models;

namespace UnipiGuide
{
    internal class MockUsers
    {
        ArrayList users;
        User selectedUser;

        public User SelectedUser { 
            get { return selectedUser; } 
            set { selectedUser = value; }
        }
        

        public ArrayList Users { get { return users; } }

        public MockUsers() { 
            users = new ArrayList();
            CreateUsers();
        }

        private void CreateUsers()
        {
            int usersLength = 10;
            for(int index = 0; index < usersLength; index++)
            {
                User user = new User();
                user.Id = index;
                user.UserName = "someUserName" + index.ToString();
                user.Password = "password"+index.ToString();
                this.users.Add(user);
            }

        }

       
    }
} 
