using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figures;

namespace figures
{
    internal class Shape
    {
        public string color;

        public Shape (string color)
        {
            this.color = color;
        }

        public void Draw(Circle circle, Rectangle rectangle)
        {
            Console.WriteLine("Нарисовать фигуру " + circle, "Нарисовать фигуру " + rectangle);  
        }

        internal void Draw(Shape shape)
        {
            throw new NotImplementedException();
        }
    }
}
