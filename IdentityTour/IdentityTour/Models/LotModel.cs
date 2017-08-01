using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityTour.Models
{
    public class LotModel
    {
        public int? ID { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? StartPrice { get; set; }
        public decimal? EndPrice { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public int? Status { get; set; }
    }
}