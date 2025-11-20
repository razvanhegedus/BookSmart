using System;
using BookSmart.Models;

namespace BookSmart.Services.Utility
{
    public interface IFeeService
    {
        decimal CalculateLateFee(Rental rental, DateTime now);
    }
}
