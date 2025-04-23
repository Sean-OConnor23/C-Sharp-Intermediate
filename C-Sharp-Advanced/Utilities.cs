using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Advanced
{
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //This is where we are able to add constraints by doing "where T : IComparable"
        public T GenericMax<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        //5 Types of Constaints
        //where T : IComparable
        //where T : Product
        //where T : struct
        //where T : class
        //where T : new()

        public void DoSomething(T value)
        {

        }


    }
}
