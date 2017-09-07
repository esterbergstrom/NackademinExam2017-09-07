using Microsoft.AspNetCore.Mvc.Rendering;
using NackademinExam2017_09_07.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackademinExam2017_09_07.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList GetSelectList()
        {
            var selectList = new SelectList(_context.ProductCategories.ToList(), "ProductCategoryId", "Name");
            return selectList;
        }
    }
}
