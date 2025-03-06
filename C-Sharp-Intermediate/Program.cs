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
        }
    }
}

