using System;

namespace Day_10
{
    /// <summary>
    /// Multi-cast delegates
    /// </summary>
    class Program
    {
        //declaration
        public delegate void RectDelegeate(double height, double width);

        public void area(double height,double width)
        {
            Console.WriteLine("Area is"+(width*height));
        }
        public void perimeter(double height,double width)
        {
            Console.WriteLine("Perimeter is {0}",2*width*height);
        }
        static void Main(string[] args)
        {
            Program c = new Program();

            RectDelegeate r = new RectDelegeate(c.area);
            //call 2nd method
            r =r+ c.perimeter;
            //invoke function
            r.Invoke(6.3,4.2);
            r = r - c.perimeter;
            r.Invoke(16.3, 4.2);
        }
    }
}
