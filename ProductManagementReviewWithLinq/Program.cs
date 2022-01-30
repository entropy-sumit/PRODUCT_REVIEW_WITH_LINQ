using System;
using System.Collections.Generic;

namespace ProductReviewMangementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management problem Statement");
            List<ProductReview> listProductReview = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=25,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=24,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=23,Rating=7,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=22,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=5,UserID=21,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductID=6,UserID=20,Rating=1,Review="Good",isLike=true},
                new ProductReview(){ProductID=7,UserID=19,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=8,UserID=18,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=9,UserID=17,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=10,UserID=16,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=11,UserID=15,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=12,UserID=14,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=13,UserID=13,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=14,UserID=12,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=15,UserID=11,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=16,UserID=10,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=17,UserID=9,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=18,UserID=8,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=19,UserID=7,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=20,UserID=6,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=21,UserID=5,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=22,UserID=4,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=23,UserID=3,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=24,UserID=2,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=25,UserID=1,Rating=8,Review="Good",isLike=true},

            };

            foreach (var list in listProductReview)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " " + "UserId: " + list.UserID + " " + "Rating: " + list.Rating + " "
                    + "Review: " + list.Review + " " + "islike : " + list.isLike + " ");
            }


        }
    }
}