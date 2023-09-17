using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.BusinessLayer.Contracts;
using Transportation.DataAccessLayer.Contracts;
using Transportation.EntityLayer.Entities;

namespace Transportation.BusinessLayer.Concrete
{
    public class ReviewManager:IReviewService
    {
        private readonly IRepositoryManager _manager;
        public ReviewManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateReview(Review review)
        {
            _manager.ReviewRepository.CreateReview(review);
            _manager.Save();
        }

        public void DeleteReview(Review review)
        {
            _manager.ReviewRepository.DeleteReview(review);
            _manager.Save();
        }

        public List<Review> GetAllReviews()
        {
            return _manager.ReviewRepository.GetAllReviews();
        }

        public Review? GetReviewById(int id)
        {
           return _manager.ReviewRepository.GetReviewById(id);
        }

       

        public void UpdateReview(Review review)
        {
            _manager.ReviewRepository.UpdateReview(review);
            _manager.Save();
        }
    }
}
