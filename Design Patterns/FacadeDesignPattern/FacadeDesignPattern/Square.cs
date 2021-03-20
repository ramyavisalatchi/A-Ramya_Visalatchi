using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing - Square");
        }
    }
}
