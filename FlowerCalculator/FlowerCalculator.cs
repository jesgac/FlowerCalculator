using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerCalculator
{
    class FlowerCalculator
    {
        public FlowerCalculator(int qty, decimal value, decimal discount)
        {
            Qty = qty;
            Value = value;
            Discount = discount;
        }

        public int Qty
        {
            get;
            private set;
        }

        public decimal Value
        {
            get; private set;
        }

        public decimal Discount
        {
            get;
            private set;
        }

        public decimal Total()
        {
            decimal Total = SubTotal();
            if (Discount >= 0)
                {
                    Total -= Total * Discount;
                }
            return Total;
            
        }

       public decimal SubTotal()
        {
            return Value * Qty;
        }

       
    }
}
