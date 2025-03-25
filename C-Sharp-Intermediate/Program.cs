﻿// See https://aka.ms/new-console-template for more information

using Amazon;

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

            //2.12
            var person2 = new Person();
            person2.SetBirthdate(new DateTime(1982, 1, 1));
            var birthdate = person2.GetBirthdate();

            //2.13
            var person3 = new Person(new DateTime(1982, 1, 1));
            //person.Birthdate = new DateTime(1982, 1, 1);  Commented out once property set to private set
            var age3 = person3.Age;

            //2.14
            var cookie = new HttpCookie();
            cookie["name"] = "Sean";
            var temp = cookie["name"];

            //3.18 --> Inheritance
            var text = new Text();
            text.Width = 100;
            text.Copy();

            //3.19 --> Composition
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();

            //4.22
            var customer2 = new Customer1();
            customer2.Promote();

            //4.23

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

