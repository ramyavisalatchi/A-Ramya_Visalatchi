using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    class Product
    {
        private List<string> _item = new List<string>();
        public void Add(string item)
        {
            _item.Add(item);
        }

        public void Show()
        {
            foreach (string item in _item)
                Console.WriteLine(item);
        }
    }
}