using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    public class Car : Vehicle
    {
        //public Car()
        //{
        //    var output = "Output";
        //}

        public Car(string registrationNumber) : base(registrationNumber)
        {
            var output = registrationNumber;
        }

    }
}
