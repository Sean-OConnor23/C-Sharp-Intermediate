using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    class Customer
    {
        public int Id;
        public string Name;

        //readonly means we can only initialize here or in the constructor
        public readonly List<Order> Orders = new List<Order>(); 

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {

        }
    }
}
