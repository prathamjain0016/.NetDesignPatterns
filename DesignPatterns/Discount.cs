using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface Discount
    {
        double ApplicableDiscount(double amount);
    }
}
