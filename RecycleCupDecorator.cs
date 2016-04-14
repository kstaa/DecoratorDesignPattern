using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class RecycleCupDecorator : Decorator
    {
        private int m_DiscountRate = 5;

        public RecycleCupDecorator(CoffeeComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Recycle Cup ($3.00)";
            this.m_Price = 3.0;
        }

        public override string GetName()
        {
            return base.GetName() +
                string.Format("\n(Please Collect your discount card for {0}%)",
                m_DiscountRate);
        }
    }

}
