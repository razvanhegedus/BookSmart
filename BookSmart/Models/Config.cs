using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSmart.Models
{
    public static class Config
    {
        public static int DefaultRentalDays { get; set; } = 14;
        public static decimal LateFeePerDay { get; set; } = 1.50m;
    }
}

