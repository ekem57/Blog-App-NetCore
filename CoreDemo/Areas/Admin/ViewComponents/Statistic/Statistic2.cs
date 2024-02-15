using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context context = new Context();
        public IViewComponentResult Invoke() { 
            ViewBag.v2 = context.Blogs.OrderByDescending(x=>x.BlogID).Select(x=> x.BlogTitle).Take(1).FirstOrDefault();
            ViewBag.v3 = context.Comments.Count();

            return View(); 
        }
    }
}
