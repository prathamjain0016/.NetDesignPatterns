using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class LessDiscount : Discount
    {
        public double ApplicableDiscount(double amount)
        {

            return 0.9 * amount;

            throw new NotImplementedException();

            
        }
    }
}
