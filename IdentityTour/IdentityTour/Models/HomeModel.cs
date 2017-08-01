using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityTour.Models
{
    public class HomeModel
    {
        public List<Category> Categories { get; set; }
        public List<LotSmallModel> Lots { get; set; }
        public int PageNumber { get; set; }
        public int Pages { get; set; }
    }
    public class Category
    {
        public int ID { get; set; }
        public int? ParrentID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; }
    }
}