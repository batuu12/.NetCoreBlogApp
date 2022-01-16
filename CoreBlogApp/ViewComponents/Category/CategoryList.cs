using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApp.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = categoryManager.GetList();
            return View(values);
        }
    }
}
