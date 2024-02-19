using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        UserManager UserManager = new UserManager(new EfUserRepository());

        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
            Context c = new Context();
            var writerName = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v2=writerName;
            return View();
        }

        public IActionResult WriterProfile() 
        {
            return View(); 
        }

        public IActionResult WriterMail()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> WriterEditProfileAsync()
        {
            //Context c = new Context();
            //var username = User.Identity.Name;
            //var usermail = c.Users.Where(x=>x.UserName == username).Select(y => y.Email).FirstOrDefault();
            //var writerID = c.Users.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();

            //var writervalues = UserManager.TGetById(writerID);
            var writervalues = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel userUpdateViewModel = new UserUpdateViewModel();
            userUpdateViewModel.namesurname = writervalues.NameSurname;
            userUpdateViewModel.imageurl = writervalues.ImageUrl;
            userUpdateViewModel.mail = writervalues.Email;
            userUpdateViewModel.username = writervalues.UserName;
            return View(userUpdateViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.NameSurname = p.namesurname;
            values.ImageUrl = p.imageurl;
            values.Name = p.username;
            values.Email = p.mail;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values,"Emre123");
            var result = await _userManager.UpdateAsync(values);

            return RedirectToAction("Index", "Dashboard");
        }


        
     

        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if(p.WriterImage != null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid().ToString() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;
            }
            w.WriterName = p.WriterName;
            w.WriterMail = p.WriterMail;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }


    }
}
