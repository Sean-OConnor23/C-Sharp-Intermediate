// See https://aka.ms/new-console-template for more information

namespace C_Sharp_Intermediate
{
    class Program
    {
        public static void Main(string[] args)
        {
            //2.7
            var person = new Person();
            person.Name = "Sean";
            var p = Person.Parse("John");
            person.Introduce(p.Name);
            Console.WriteLine("TEMP");

            //2.8
            var customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            //2.9
            var person1 = new Person
            {
                Name="Test",
                Age=21
            };

            //2.10

            UsePoints();
            UseParams();
            //Shows use of out modifier
            //var number = int.Parse("abc"); --> Throws Exception
            var num = 0;
            //returns bool
            var result = int.TryParse("abc",out num);

            if (result) Console.WriteLine(num);
            else Console.WriteLine("Conversion Failed");

            //2.11
            var customer1 = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            
        }

        static void UseParams()
        {
            var calculator = new Calculator();

            //Shows how params modifier works
            calculator.Add(1, 2, 3, 4);
            calculator.Add(new int[] { 1, 2, 3, 4 });
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                point.Move(200, 200);
            }
            catch (Exception)
            {

                Console.WriteLine("An Unexpected Error Ocurred.");
            }
        }

    }
}

