using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            var output = "Object copied to clipboard";
        }

        public void Duplicate()
        {
            var ouput = "Object was duplicated";
        }
    }
}
