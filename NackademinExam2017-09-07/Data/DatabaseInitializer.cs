using NackademinExam2017_09_07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackademinExam2017_09_07.Data
{
    public static class DatabaseInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            var productCategories = new List<ProductCategory>()
            {
                new ProductCategory()
                {
                    Name = "TV"
                },
                new ProductCategory()
                {
                    Name = "VHS"
                },
                new ProductCategory()
                {
                    Name = "DVD"
                }
            };

            context.ProductCategories.AddRange(productCategories);
            context.SaveChanges();
        }
    }
}
