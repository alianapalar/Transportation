using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.BusinessLayer.Contracts
{
    public interface IReviewService
    {
        void CreateReview(Review review);
        void UpdateReview(Review review);
        void DeleteReview(Review review);
        Review? GetReviewById(int id);
       
        List<Review> GetAllReviews();
    }
}
