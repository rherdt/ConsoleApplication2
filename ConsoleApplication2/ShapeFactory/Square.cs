using System;

namespace ShapeSpace
{
    class Square : A_Shape
    {
        public Square(string name, double width) : base(name, width) { }

        public override double getArea()
        {
            return Math.Pow(this.getWidth(), 2);
        }
    }
}
