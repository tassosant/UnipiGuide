using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnipiGuide.Models
{
    internal class User
    {
        string username;
        int id;
        string password;
        public string UserName { 
            get { return username; }
            set { username = value; }
        }

        public int Id { 
            get { return id; } 
            set { id = value; }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
            }
        }

        

        
    }
}
