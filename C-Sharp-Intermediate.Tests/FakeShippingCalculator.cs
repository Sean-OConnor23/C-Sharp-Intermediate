using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate.Tests
{
    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order1 order)
        {
            return 1;
        }
    }
}
