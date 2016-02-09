using System;

namespace ShapeSpace
{
    class Rectangle: A_Shape
    {
        public Rectangle(string name, double width, double height) : base(name, width, height) { }

        public override double getArea()
        {
            return this.getHeight() * this.getWidth();
        }
    }
}
