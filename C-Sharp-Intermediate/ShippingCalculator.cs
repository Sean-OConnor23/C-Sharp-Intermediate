using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order1 order)
        {
            if (order.TotalPrice < 30f) return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
