using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    public abstract class Shape2
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            var output = "Copy shape into clipboard";
        }

        public void Select()
        {
            var output = "Select the shape";
        }
    }

}
