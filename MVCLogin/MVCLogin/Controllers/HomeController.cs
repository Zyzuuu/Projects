using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLogin.Models;
using System.Web.Security;
using System.Threading;
using System.Globalization;

namespace MVCLogin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string Language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Language);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(Language);
            ViewBag.Message = "INDEX VIEWBAG MESSAGE";
            return View();
        }

        public ActionResult Login(string Language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Language);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(Language);
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User u)
        {
            //this asction is for handle post (login)
            if (ModelState.IsValid) // this is check validity
            {

                using (MVCLogin.Models.zyzu_databaseEntities1 dc = new MVCLogin.Models.zyzu_databaseEntities1())
                {
                    var v = dc.Users.Where(a => a.UserName.Equals(u.UserName) && a.Password.Equals(u.Password)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["LogedUserID"] = v.UserID.ToString();
                        Session["UserName"] = v.UserName.ToString();
                        return RedirectToAction("AfterLogin");
                    }
                }
               
            }
            return RedirectToAction("Login");

        }
    

        public ActionResult AfterLogin(string Language)
        {
            if (Session["LogedUserID"] != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Language);
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(Language);
                return View();
            }
            else
            {
                return RedirectToAction("Login  ");
            }
        }

        public ActionResult LogOut(string Language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Language);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(Language);
            Session.Clear();
            return RedirectToAction("Login", "Home");
        }

        public ActionResult MyProjects(string Language)
        {
            if (Session["LogedUserID"] != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Language);
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(Language);
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }

        }
        public ActionResult AboutMe(string Language)
        {
            if (Session["LogedUserID"] != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Language);
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(Language);
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }

        }
        public ActionResult Contact(string Language)
        {
            if (Session["LogedUserID"] != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Language);
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(Language);
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }

        }


    }
}