using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order1 order);
    }
}
