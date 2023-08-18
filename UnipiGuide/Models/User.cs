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
        int reviewId;
        Review Review { get; set; }
        string password;
        public string UserName { 
            get { return username; }
            set { username = value; }
        }

        public int Id { 
            get { return id; } 
            set { id = value; }
        }

        public int ReviewId
        {
            get { return reviewId; }
            set { reviewId = value; }
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
