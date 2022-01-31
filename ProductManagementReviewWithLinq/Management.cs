using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace ProductReviewMangementWithLinq
{
    public class Management
    {
        public void TopRecordsList(List<ProductReview> review)
        {
            var recordData = (from productReviews in review
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " " + "UserId: " + list.UserID + " " + "Rating: " + list.Rating + " "
                    + "Review: " + list.Review + " "+ "islike:" + list.isLike + " ");
            }
        }
        public void SelectedRecords(List<ProductReview> review)
        {
            var recordData = from productReviews in review
                             where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                             && productReviews.Rating > 3
                             select productReviews;

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " " + "UserId: " + list.UserID + " " + "Rating: " + list.Rating + " "
                    + "Review: " + list.Review + " " + list.isLike + " ");
            }
        }
        public void RetrieveCountOfRecords(List<ProductReview> review)
        {
            var recordData = review.GroupBy(x => x.ProductID).
                                    Select(x => new { ProductID = x.Key, Count = x.Count() });

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + "-------------" + list.Count);
            }

        }
        public void RetrieveProductIdandReview(List<ProductReview> review)
        {
            var recordData = (from productreview in review select new { ProductId = productreview.ProductID, Review = productreview.Review });


            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:" + list.ProductId + "||Review:" + list.Review);

            }
        }
    }
}