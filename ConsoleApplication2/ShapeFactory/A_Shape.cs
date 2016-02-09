using System;
using System.Collections.Generic;

namespace ShapeSpace.ShapeFactory
{
    abstract class A_Shape : IComparable<A_Shape>
    {
        private double width;
        private double height;
        private string name;

        protected A_Shape(string name, double width, double height)
        {
            this.height = height;
            this.width = width;
            this.name = name;
        }

        protected A_Shape(string name, double width)
        {
            this.width = width;
            this.name = name;
        }

        public abstract double getArea();

        public double getWidth() { return this.width; }
        public double getHeight() { return this.height; }
        public string getName() { return this.name; }

        public int CompareTo(A_Shape other)
        {
            if(this.getName().CompareTo(other.getName()) == 0)
            {
                return this.getArea().CompareTo(other.getArea());
            }
            return this.getName().CompareTo(other.getName());
        }

        public void sort(List<A_Shape> list)
        {
            list.Sort();
        }

        public string toString()
        {
            string output = (this.getName() + ", Area: " + this.getArea());
            return output;
        }
    }
}
