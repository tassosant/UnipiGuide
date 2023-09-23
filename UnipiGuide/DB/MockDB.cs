using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
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
        static ArrayList comments;
        private static int usersCount = 10;
        private static Random random = new Random();
        public static ArrayList Users { get { return users; } }
        public static ArrayList Reviews { get { return reviews; } }

        public static User SelectedUser { 
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
                CreateUser("user");
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

        public static void CreateGuest(User guest)
        {
            int id = users.Count;
            guest.Id = id;
            guest.UserName = "anonymous";
            guest.Review = guest.Review;
            users.Add(guest);
        }


        public void CreateUser(string username)
        {
            int id = users.Count;
            User user = new User();
            user.UserName = username+id.ToString();
            user.Password = "password"+id.ToString();           
            user.Review = CreateReview((string)comments[id], id);                        
            selectedUser = user;
            users.Add(user);
        }

        public Review CreateReview(string comment, int id)
        {
            Review review= new Review();
            review.ReviewId = id;
            review.Comment = comment;
            review.Stars = random.Next(1,6);
            reviews.Add(review);
            return review;
        }

        /*public void BindReviewToUser(int reviewId, int userId)
        {
            
        }*/


        private void CreateComments()
        {
            comments = new ArrayList();
            int index = 1;
            comments.Add("Very nice university");
            index++;
            comments.Add("Very nice teachers");
            index++;
            comments.Add("Bad infastructure");
            index++;
            comments.Add("Toilets stink");
            index++;
            for (int temp = index; temp <= usersCount; temp++)
            {
                comments.Add("comment"+temp);
            }
            

        }
        

        public MockDB() {
            //delete properties because they are static
            users = null;
            reviews = null;
            selectedUser = null; 

            CreateComments();
            users = new ArrayList();
            reviews = new ArrayList();
            CreateMockUsers();

            
            selectedUser = null;

            //Array.Copy(CreateMockUsers(), 0, Users, 0, CreateMockUsers().Length);
            
        }


    }
}
