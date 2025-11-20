using System;
using BookSmart.Models;

namespace BookSmart.Services.Utility
{
    public class FeeService : IFeeService
    {
        public decimal CalculateLateFee(Rental rental, DateTime now)
        {
            int daysLate = rental.GetOverdueDays(now);
            return daysLate * Config.LateFeePerDay;
        }
    }
}

