using LapTrinhWeb.Models.ViewModel;
using LapTrinhWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LapTrinhWeb.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private ThietKeWebEntities db = new ThietKeWebEntities();
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(AdminRegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var existUser = db.Users.SingleOrDefault(u => u.Username == model.Username);
                if (existUser != null)
                {
                    ModelState.AddModelError("Username", "Tên đăng nhập đã tồn tại.");
                    return View(model);
                }
                var user = new User
                {
                    Username = model.Username,
                    Password = model.Password,
                    UserRole = "Admin"
                };
                db.Users.Add(user);
                db.SaveChanges();
                Session["Role"] = user.UserRole;
                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginVM model, bool rememberMe)
        {
            if (ModelState.IsValid)
            {
                var validUser = db.Users.SingleOrDefault(u => u.Username == model.Username && u.Password == model.Password && u.UserRole == "Admin");
                if (validUser != null)
                {
                    Session["Username"] = validUser.Username;
                    Session["Role"] = validUser.UserRole;
                    FormsAuthentication.SetAuthCookie(validUser.Username, rememberMe);
                    return RedirectToAction("Index", "Admin_Home");

                }
                else
                {
                    ModelState.AddModelError("", "Tên dăng nhập hoặc mật khẩu không đúng");
                }
            }
            return View(model);
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Admin_Home");
        }
        
    }
}