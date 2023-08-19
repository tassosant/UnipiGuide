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
    public class CreateMockDB
    {
        ArrayList users;
        ArrayList reviews;
        User selectedUser;

        public ArrayList Users { get { return users; } }
        public ArrayList Reviews { get { return reviews; } }


        private Review CreateReview(int id)
        {
            Review review = new Review();
            review.ReviewId = id;
            review.Comment= "Comment"+id.ToString();
            return review;
        }
       


        private void CreateMockUsers()
        {
            int usersLength = 10;
            
            int index;
            for(index = 0; index < usersLength; index++)
            {
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
            int id = this.users.Count;
            User user = new User();
            user.UserName = username+id.ToString();
            user.Password = "password"+id.ToString();
            this.selectedUser = user;
            CreateReview("comment");
        }

        public void CreateReview(string comment)
        {
            Review review= new Review();
            review.ReviewId = this.selectedUser.Id;
            review.Comment = comment + review.ReviewId.ToString();
            this.reviews.Add(review);
        }

        public void BindReviewToUser(int reviewId, int userId)
        {

        }

        

        public CreateMockDB() {
            this.users = new ArrayList();
            this.reviews = new ArrayList();
            CreateMockUsers();

            
            this.selectedUser = null;

            //Array.Copy(CreateMockUsers(), 0, Users, 0, CreateMockUsers().Length);
            
        }
    }
}
