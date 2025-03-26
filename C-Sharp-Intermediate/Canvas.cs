using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    public class Canvas
    {
        public void DrawShape(List<Shape1> shapes)
        {
            foreach(Shape1 shape in shapes)
            {
                //switch (shape.Type)
                //{
                //    case ShapeType.Circle:
                //        break;
                //    case ShapeType.Rectangle:
                //        break;
                //}
                shape.Draw();
            }
        }
    }
}
