using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    class ConcreteChildPackage:Builder
    {
        private Product _product = new Product();

        public override void Savories()
        {
            _product.Add("\t=> 1 Savory");
        }

        public override void Sweets()
        {
            _product.Add("\t=> 2 Sweets");
        }

        public override Product GetResult()
        {
            return _product;
        }

    }
}
