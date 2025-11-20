using System;

namespace BookSmart.Services.Utility
{
    public class IdService : IIdService
    {
        public string GenerateId(string prefix)
        {
            return $"{prefix}{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        }
    }
}
