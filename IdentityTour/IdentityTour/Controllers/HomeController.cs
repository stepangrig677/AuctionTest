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
            model.Categories = new List<Models.Category>();
            var categories = DB.Categories.ToList();

            foreach (var x in categories)
            {
                if (x.ParrentID == null)
                {
                    var category = new Models.Category() { Name = x.Name, ID = x.ID, ParrentID = x.ParrentID };
                    category.Categories= new List<Models.Category>();
                    model.Categories.Add(category);
                }
            }
            foreach (var x in categories)
            {
                if (x.ParrentID != null)
                {
                    var parent = model.Categories.Where(a => a.ID == x.ParrentID).First();
                    parent.Categories.Add(new Models.Category() { Name = x.Name, ID = x.ID, ParrentID = x.ParrentID });
                }
            }


            var lots= DB.Lots.ToList().Take(6); ;
            model.Lots = new List<LotSmallModel>();

            foreach (var x in lots)
            {
                model.Lots.Add(new LotSmallModel() {ID=x.ID, Name=x.Name, Description=x.Description, Image = x.Images.Split(',')[0] });
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