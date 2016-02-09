using System;


namespace ShapeSpace.ShapeFactory
{
    class Circle : A_Shape
    {
        public readonly double pi = Math.PI;
        //width defines diameter, not radius
        public Circle(string name, double width) : base(name, width) { }

        public override double getArea()
        {
            return (Math.Pow((.5 * this.getWidth()), 2)) * pi;
        }
    }
}
