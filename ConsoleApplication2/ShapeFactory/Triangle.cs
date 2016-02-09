using System;

namespace ShapeSpace
{
    class Triangle : A_Shape
    {
        public Triangle(string name, double width, double height) : base(name, width, height) { }

        public override double getArea()
        {
            return (.5 * this.getWidth()) * this.getHeight();
        }
    }
}
