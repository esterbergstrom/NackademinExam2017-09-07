using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackademinExam2017_09_07.Services
{
    public interface IProductCategoryService
    {
        SelectList GetSelectList();
    }
}
