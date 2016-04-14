using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class MilkDecorator : Decorator
    {
        public MilkDecorator(CoffeeComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Milk ($1.00)";
            this.m_Price = 1.0;
        }
    }
}
