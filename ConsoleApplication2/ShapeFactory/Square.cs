using System;

namespace ShapeSpace.ShapeFactory
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
