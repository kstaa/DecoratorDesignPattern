using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class WhipDecorator : Decorator
    {
        public WhipDecorator(CoffeeComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Whip Cream ($0.50)";
            this.m_Price = 0.50;
        }
    }
}
