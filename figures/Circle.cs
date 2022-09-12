using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figures;

namespace figures
{
    internal class Circle : Shape
    {
         int x;
         int y;

        public Circle(int x, int y, string color) : base(color)
        {
            this.x = x;
            this.y = y;
        }
        public override bool Equals(object obj) 
        { 
         if (obj is Rectangle rectangle) return color == rectangle.color;
            return false;
        }
        public override int GetHashCode() => color.GetHashCode();
    }
}
