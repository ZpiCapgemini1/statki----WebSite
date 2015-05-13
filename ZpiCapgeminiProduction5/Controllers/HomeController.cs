using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZpiCapgeminiProduction5.Models;

namespace ZpiCapgeminiProduction5.Controllers
{
    public class HomeController : Controller
    {
        //User Registration
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(GRACZ newPlayerData)
        {
            if (ModelState.IsValid)
            {
                using (ZpiCapgeminiDataBaseEntities dc = new ZpiCapgeminiDataBaseEntities())
                {
                    if (dc.GRACZ.Any(x => x.Login == newPlayerData.Login))
                    {
                        ModelState.AddModelError("Login", "Podany login już istnieje, podaj inny !!");
                    }
                    else
                    {
                        dc.GRACZ.Add(newPlayerData);
                        dc.SaveChanges();
                        ModelState.Clear();
                        newPlayerData = null;
                        ViewBag.Message = "Successfully Registration Done";
                    }
                }
            }
            return View(newPlayerData);
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}