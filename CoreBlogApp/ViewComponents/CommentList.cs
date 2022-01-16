using CoreBlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApp.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                    UserName="Batuhan"
                },
                new UserComment
                {
                    Id=2,
                    UserName="Murat"
                }
            };
            return View(commentValues);
        }
    }
}
