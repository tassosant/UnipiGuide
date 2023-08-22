using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnipiGuide.Models;

namespace UnipiGuide.Controllers
{
    public class MockDB
    {
        static ArrayList users;
        static ArrayList reviews;
        static User selectedUser;

        public static ArrayList Users { get { return users; } }
        public static ArrayList Reviews { get { return reviews; } }

        public User SelectedUser { 
            get { return selectedUser; } 
            set { selectedUser = value; }
        }

        /*private Review CreateReview(int id)
        {
            Review review = new Review();
            review.ReviewId = id;
            review.Comment= "Comment"+id.ToString();
            return review;
        }*/
       


        private void CreateMockUsers()
        {
            int usersLength = 10;
            
            int index;
            for(index = 0; index < usersLength; index++)
            {
                CreateUser("someUsername");
                /*User user = new User();
                user.Id = index;
                user.UserName = "aUserName" + index.ToString();
                user.Password = "password" + index.ToString();
                Review review = CreateReview(user.Id);
                user.Review = review;
                user.ReviewId = review.ReviewId;
                this.users.Add(user);
                */
            }

           
            
        }

        public void CreateUser(string username)
        {
            int id = users.Count;
            User user = new User();
            user.UserName = username+id.ToString();
            user.Password = "password"+id.ToString();            
            user.Review = CreateReview("comment", id);                        
            selectedUser = user;
            users.Add(user);
        }

        public Review CreateReview(string comment, int id)
        {
            Review review= new Review();
            review.ReviewId = id;
            review.Comment = comment + review.ReviewId.ToString();
            reviews.Add(review);
            return review;
        }

        /*public void BindReviewToUser(int reviewId, int userId)
        {
            
        }*/

        

        public MockDB() {
            //delete properties because they are static
            users = null;
            reviews = null;
            selectedUser = null; 


            users = new ArrayList();
            reviews = new ArrayList();
            CreateMockUsers();

            
            selectedUser = null;

            //Array.Copy(CreateMockUsers(), 0, Users, 0, CreateMockUsers().Length);
            
        }
    }
}
