using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    public class Shape1
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Position Position { get; set; }
        //public ShapeType Type { get; set; }

        public virtual void Draw()
        {

        }
    }
}
