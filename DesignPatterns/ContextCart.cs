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

       

        public void setTier(Discount _Discount)
        {
            this._Discount = _Discount;
        }

        public double TotalAmount(double amount) 
        {
            return _Discount.ApplicableDiscount(amount);
        }
    }
}
