using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IdentityTour.Models;
using IdentityTour.TestDB;

namespace IdentityTour.Controllers
{
    public class LotController : Controller
    {
        private TestDbContext DB = new TestDbContext();

        // GET: Lot
        public ActionResult Index(int id)
        {
            var lot = DB.Lots.SingleOrDefault(a => a.ID == id);
            var model = new LotModel()
            {
                ID=lot.ID,
                StartTime = lot.StartTime,
                EndTime = lot.EndTime,
                StartPrice = lot.StartPrice,
                EndPrice = lot.EndPrice,
                Name = lot.Name,
                Description = lot.Description,
                Images = lot.Images,
                Status = lot.Status
            };

            return View(model);
        }

        [Authorize]
        public ActionResult AddLot()
        {
            return View();
        }
    }
}