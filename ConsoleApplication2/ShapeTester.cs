using System;
using System.Collections.Generic;

namespace ShapeSpace
{
    class ShapeTester
    {
        public static void Main(String[] args)
        {
            ShapeFactory.ShapeFactory factory = new ShapeFactory.ShapeFactory();

            ShapeFactory.A_Shape mySquare = factory.getShape("square", "MyFirstSquare", 10);

            Console.WriteLine(mySquare.toString());

            Console.ReadLine();
        }
    }
}
