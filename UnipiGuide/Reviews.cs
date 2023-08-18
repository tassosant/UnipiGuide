using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnipiGuide.Models;

namespace UnipiGuide
{
    internal class Reviews
    {
        ArrayList reviews;
        public Reviews()
        {
            reviews = new ArrayList();

        }

        public void CreateReview(Review review,int userId)
        {
            
            this.reviews.Add(review);
        }

        /*public Review SelectReviewById(int reviewId)
        {
            foreach (Review review in this.reviews)
            {
                if (review.ReviewId == reviewId)
                {
                    return review;
                }
            }
            return null;
        }*/
    }
}
