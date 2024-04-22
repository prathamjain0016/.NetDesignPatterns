using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class HigherDiscount : Discount
    {
        public double ApplicableDiscount(double amount)
        {
            return 0.8 * amount;

            
        }
    }
}
