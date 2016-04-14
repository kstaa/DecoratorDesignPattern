using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class HouseBlend : CoffeeComponent
    {
        private string m_Name = "House Blend ($1.50)";
        private double m_Price = 1.50;

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
