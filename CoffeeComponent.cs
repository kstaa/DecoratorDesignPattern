using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public abstract class CoffeeComponent
    {
        public abstract string GetName();
        public abstract double GetPrice();

    }
}
