using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing - Rectangle");
        }
    }
}
