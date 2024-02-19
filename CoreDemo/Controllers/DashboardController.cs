using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            Context context = new Context();

            var username = User.Identity.Name;
            ViewBag.Username = username;
            var usermail = context.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
            var writerid = context.Writers.Where(x => x.WriterMail == usermail).Select(x => x.WriterId).FirstOrDefault();
            ViewBag.v1 = context.Blogs.Count().ToString();
            ViewBag.v2 = context.Blogs.Where(x => x.WriterId == writerid).Count().ToString();
            ViewBag.v3 = context.Categories.Count().ToString();

            return View();
        }
    }
}
