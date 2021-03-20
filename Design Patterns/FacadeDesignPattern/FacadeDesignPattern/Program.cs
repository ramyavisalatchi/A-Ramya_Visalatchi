using System;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker shape = new ShapeMaker();

            shape.drawCircle();
            shape.drawRectangle();
            shape.drawSquare();

            Console.Read();
        }
    }
}
