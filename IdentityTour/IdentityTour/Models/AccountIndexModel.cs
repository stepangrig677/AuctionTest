using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityTour.Models
{
    public class AccountIndexModel
    {
        public List<LotModel> OldLots { get; set; }
        public List<LotModel> CurrentLots { get; set; }
        public List<LotModel> MyOwnLots { get; set; }
    }
}