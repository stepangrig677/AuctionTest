using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IdentityTour.TestDB
{
    public class Test
    {
        public int ID { get; set; }
        public DateTime? OperationTime { get; set; }
        public string IpAddress { get; set; }
        public string Operands { get; set; }
        public decimal Result { get; set; }
    }
}