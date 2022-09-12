using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figures;

namespace figures
{
    internal class Rectangle:Shape
    {
         public int x;
         public int y;
        
        public Rectangle (int x, int y, string color) :base(color)
        {
            this.x = x;
            this.y = y;
        }
        public override bool Equals(object obj)
        {
            if (obj is Circle circle) return color == circle.color;
            return false;
        }
        public override int GetHashCode() => color.GetHashCode();
    }
}
