using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Customer1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(true);
            var output = rating.ToString();

            var calculator = new RateCalculator();
            var rating1 = calculator.Calculate(this);
        }

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }

    }
}
