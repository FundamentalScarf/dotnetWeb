using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using portfolio.DAL;
using portfolio.Models;
using System.Net;

namespace portfolio.Controllers
{
    public class PlayerController : Controller
    {
		private MyDbContext db = new MyDbContext();

		// GET: Player/
        public ActionResult Index()
        {
			return View (db.Players.ToList());
        }

		public ActionResult Details(int? id = -1)
		{
			if(id == -1)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Player player = db.Players.Find(id);
			if(player == null)
			{
				return HttpNotFound();
			}
			return View(player);
		}
    }
}
