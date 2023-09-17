using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.DataAccessLayer.Contracts
{
    public interface IReviewRepository : IRepositoryBase<Review>
    {
        void CreateReview(Review review);
        void UpdateReview(Review review);
        void DeleteReview(Review review);
        Review? GetReviewById(int id);
       
        List<Review> GetAllReviews();
    }
}
