using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    abstract class Builder
    {
        public abstract void Sweets();
        public abstract void Savories();
        public abstract Product GetResult();
    }
}
