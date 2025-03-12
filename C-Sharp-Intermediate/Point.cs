using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            //defensive programming by null checking
            if (newLocation == null) throw new ArgumentNullException("newLocation");

            this.Move(newLocation.X, newLocation.Y);
        }
    }
}
