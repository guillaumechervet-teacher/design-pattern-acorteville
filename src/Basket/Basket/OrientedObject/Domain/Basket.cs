using System.Collections;
using System.Collections.Generic;

namespace Basket.Domain
{
    public class Basket
    {
        private readonly IList<BasketLine> _basketLine;

        public Basket(IList<BasketLine> basketLine)
        {
            _basketLine = basketLine;
        }

        public int CalculateAmount()
        {
            int total = 0;
            foreach (var line in _basketLine)
            {
                total += line.Calculate();
            }

            return total;
        }
    }

    

    
}