﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        public Vehicle()
        {
            var output = "Output";
        }

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
        }
    }
}
