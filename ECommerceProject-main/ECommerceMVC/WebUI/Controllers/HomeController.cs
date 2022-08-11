using Common;
using Model.Context;
using Model.Entity;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models.ViewModels;
using WebUI.Attributes;
using System.Web.Security;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {

        CategoryService categoryService = new CategoryService();
        AppUserService appUserService = new AppUserService();
        ProductService productService = new ProductService();
        public PartialViewResult _NavbarPartial()
        {
            
            var categories = categoryService.GetList();
            return PartialView(categories);
        }


        public ActionResult Index()
        {
            return View(productService.GetDefault(x=>x.Status==Core.CoreEnum.Status.Active));
        }



        public ActionResult Register()
        {
            TempData["Categories"] = categoryService.GetList();

            return View();
        }

        [HttpPost]
        public ActionResult Register(AppUserVM newUser, HttpPostedFileBase ProfilePhotoPath)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = newUser.UserName,
                    Email = newUser.Email,
                    Password = newUser.Password
                };
                user.ProfilePhotoPath= ImageUploader.UploadImage("~/Content/userImages", ProfilePhotoPath);

                //Kayıt olduğunuz için teşekkür ederiz. Üyeliğinizi aktif hale getirmek için aşağıdaki linke tıklayın.
                //http://localhost:8965/Home/Activation/0265655-5665-126545


              



                if (appUserService.Any(x => x.Email == newUser.Email || x.UserName == newUser.UserName))
                {
                    TempData["error"] = "bu kullanıcı daha önce kayıt olmuş";
                    return View();
                }
                else
                {
                    user.ActivationId = Guid.NewGuid();
                    appUserService.Add(user);

                    string message = $"Kayıt olduğunuz için teşekkür ederiz. Üyeliğinizi aktif hale getirmek için linke tıklayın. https://localhost:44379/"+ "Home/CompleteRegistration/"+ user.ActivationId;
                    MailSender.SendEmail(user.Email, "Yeni Kullanıcı", message);
                    return View("RegisterPending", user.ActivationId);
                }




            }
            else
            {
                return View(newUser);
            }


            
        }


        public ActionResult RegisterPending(Guid id)
        {
           
            AppUser user = appUserService.GetDefault(x => x.ActivationId == id).FirstOrDefault();
            ViewBag.User = user;
            return View();
        }


        public ActionResult CompleteRegistration(Guid id)
        {
            if (id != null)
            {
                var result = appUserService.Any(x => x.ActivationId == id);
                if (result)
                {
                    AppUser user = appUserService.GetDefault(x => x.ActivationId == id).FirstOrDefault();
                    user.IsActive = true;
                    appUserService.Update(user);
                    return RedirectToAction("Login");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
           
        }

        //public ActionResult TestMail()
        //{
        //    MailSender.SendEmail("fatih.gunalp@gmail.com", "Test maili", "Hello World!");
        //    return View();
        //}

        //CompleteRegistration


        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        //[AcFilter]
        public ActionResult Login(LoginVM login)
        {

            if (ModelState.IsValid)
            {
                if (appUserService.Any(x => x.UserName == login.UserName))
                {

                    var result = appUserService.UserLogin(login.UserName, login.Password);



                    if (result)
                    {
                        AppUser user = appUserService.GetDefault(x => x.UserName == login.UserName && x.Password == login.Password).FirstOrDefault();
                        
                        Session["user"] = user;

                        //Cookie
                        FormsAuthentication.SetAuthCookie(user.UserName, true);


                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View();
                    }
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
            
           
        }

        public ActionResult LogOut(AppUser user)
        {
            if (user != null)
            {
                Session.Remove("user");
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}