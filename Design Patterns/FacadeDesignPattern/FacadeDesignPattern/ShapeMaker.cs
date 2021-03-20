using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    class ShapeMaker
    {
        Shape circle;
        Shape rectangle;
        Shape square;

        public ShapeMaker()
        {

        }

        public void drawCircle()
        {
            circle = new Circle();
            circle.draw();
        }
        public void drawSquare()
        {
            square = new Square();
            square.draw();
        }
        public void drawRectangle()
        {
            rectangle = new Rectangle();
            rectangle.draw();
        }
    }
}
