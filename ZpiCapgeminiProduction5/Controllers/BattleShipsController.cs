using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZpiCapgeminiProduction5.Controllers
{
    public class BattleShipsController : Controller
    {
        // GET: BattleShips
        public ActionResult BattleShips()
        {
            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}