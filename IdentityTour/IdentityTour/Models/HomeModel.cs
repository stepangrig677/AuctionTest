using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityTour.Models
{
    public class HomeModel
    {
        public Dictionary<string,List<string>> Categories { get; set; }
        public List<LotSmallModel> Lots { get; set; }
        public int PageNumber { get; set; }
        public int Pages { get; set; }
    }
    
}