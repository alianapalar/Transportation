using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.DataAccessLayer.Context;
using Transportation.DataAccessLayer.Contracts;
using Transportation.EntityLayer.Entities;

namespace Transportation.DataAccessLayer.Concrete
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(TransportationContext context) : base(context)
        {
        }

        public void CreateReview(Review review)=>Create(review);
        

        public void DeleteReview(Review review)=>Delete(review);


        public List<Review> GetAllReviews() => _context.Reviews.Include(r=>r.User).ToList();
        

        public Review? GetReviewById(int id)
        {
            return FindByCondition(r=>r.ReviewId.Equals(id));
        }

        

        public void UpdateReview(Review review)=>Update(review);
       
    }
}
