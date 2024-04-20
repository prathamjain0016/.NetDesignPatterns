using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ContextCart
    {
        private Discount _Discount;

        public ContextCart(Discount discount)
        {
            _Discount = discount;
        }

        public double TotalAmount(double amount) 
        {
            return _Discount.ApplicableDiscount(amount);
        }
    }
}
