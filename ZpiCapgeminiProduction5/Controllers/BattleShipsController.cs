using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZpiCapgeminiProduction5.Hubs;
using ZpiCapgeminiProduction5.Models;

namespace ZpiCapgeminiProduction5.Controllers
{
    public class BattleShipsController : Controller
    {
        // GET: BattleShips
        public ActionResult BattleShipsVsPc()
        {
            return View();
        }

        public ActionResult BattleShipsVsPlayer()
        {
            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }

        public ActionResult UsersList()
        {
            return View(ChatHub.ConnectedUsers);
        }

        public ActionResult UsersIndex()
        {
            ZpiCapgeminiDataBaseEntities DbContext = new ZpiCapgeminiDataBaseEntities();
            
            return View(DbContext.GRACZ);
        }

    }
}