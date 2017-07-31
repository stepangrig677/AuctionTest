using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityTour.TestDB
{
    public class Betting
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? UserID { get; set; }
        public int? LotID { get; set; }
        public DateTime? Created { get; set; }
        public decimal? Amount { get; set; }
    }
}