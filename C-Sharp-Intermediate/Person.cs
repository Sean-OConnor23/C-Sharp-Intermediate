using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    class Person
    {
        public string Name;
        public int Age;

        //With private variable we can put underscore in front of (2.12)
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

        //2.13  --> auto-implementation will create private var for us
        public DateTime Birthdate { get; private set; }

        public int Age1
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        public string Name1 { get; set; }

        public Person()
        {
            
        }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
}
