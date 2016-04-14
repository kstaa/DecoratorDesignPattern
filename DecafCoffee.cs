using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class DecafCoffee : CoffeeComponent
    {
        private string m_Name = "Decaf Coffee ($2.00)";
        private double m_Price = 2.00;

        public override string GetName()
        {
            return m_Name;
        }

        public override double GetPrice()
        {
            return m_Price;
        }
    }
}
