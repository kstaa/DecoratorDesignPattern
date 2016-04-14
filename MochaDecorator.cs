using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class MochaDecorator : Decorator
    {
        public MochaDecorator(CoffeeComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Mocha ($1.25)";
            this.m_Price = 1.25;
        }
    }
}
