using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityTour.Controllers
{
    public class LotController : Controller
    {
        // GET: Lot
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult AddLot()
        {
            return View();
        }
    }
}