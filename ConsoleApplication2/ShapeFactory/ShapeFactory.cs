using System;

namespace ShapeSpace.ShapeFactory
{
    class ShapeFactory
    {
        public A_Shape getShape(string type, string name, double width, double height)
        {
            A_Shape shape;

            if (type.ToLower().Equals("rectangle"))
                shape = new Rectangle(name, width, height);
            else if (type.ToLower().Equals("triangle"))
                shape = new Triangle(name, width, height);
            else
                throw new InvalidOperationException("Illegal Argument.");
            return shape;
        }

        public A_Shape getShape(string type, string name, double width)
        {
            A_Shape shape;

            if (type.ToLower().Equals("circle"))
                shape = new Circle(name, width);
            else if (type.ToLower().Equals("square"))
                shape = new Square(name, width);
            else
                throw new InvalidOperationException("Illegal Argument.");
            return shape;
        }

    }
}
