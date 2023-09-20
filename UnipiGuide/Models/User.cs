using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnipiGuide.Models
{
    public class User
    {
        string username;
        int id;
        int reviewId;
        Review review;
        string password;


        public User() { }

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

        public Review Review { 
            get { return review; }
            set { review = value; }
        }
        

        

        
    }
}
