using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.Sweets();
            builder.Savories();
        }
    }
}
