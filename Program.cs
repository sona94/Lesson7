using System;

namespace EncapsulationExample
{

   /* class Rectangle
    {
        //member Variables
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    } */

    class Rectangle
    {
        // memeber Variables
        private double length;
        private double width;

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Lenghth:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width:");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area : {0}", GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display(); */

               
            // using the private Access Specifier Variables;
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.Display();
          
        }
    }
}
