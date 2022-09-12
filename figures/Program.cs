using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figures;

namespace figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape ("");
            Circle circle = new Circle(4, 3, "розовый");
            Rectangle rectangle = new Rectangle(5, 4, "белый");
            Shape[] shapes = new Shape[1];
            shapes[0] = new Circle(5, 4, "розовый");
            shapes[1] = new Rectangle(4, 3, "белый");
            
            for (int i = 0; i < shapes.Length; i++)
            {
                    shape.Draw(shapes[i]);
            }

        }
    }
}
