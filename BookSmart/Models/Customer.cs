using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSmart.Models
{
    public struct Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;
    }
}
