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
    public class HomeController : Controller
    {
        private TestDbContext DB = new TestDbContext();

        public ActionResult Index()
        {
            var model = new HomeModel();
            model.Categories = new Dictionary<string, List<string>>();
            var categories = DB.Categories.ToList();

            foreach (var x in categories)
            {
                if (x.ParrentID == null) model.Categories.Add(x.Name, new List<string>());
            }

            foreach (var x in categories)
            {
                if (x.ParrentID != null) model.Categories[categories.Where(a=>a.ID==x.ParrentID).Select(a=>a.Name).First()].Add(x.Name);
            }

            var lots= DB.Lots.ToList();
            model.Lots = new List<LotSmallModel>();

            foreach (var x in lots)
            {
                model.Lots.Add(new LotSmallModel() {Name=x.Name, Description=x.Description, Image = x.Images });
            }

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}