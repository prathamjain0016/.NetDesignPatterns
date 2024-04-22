using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class NoDiscount : Discount
    {
        public double ApplicableDiscount(double amount)
        {
            return amount;

                    }
    }
}
