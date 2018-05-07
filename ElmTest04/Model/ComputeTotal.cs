using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ComputeTotal : ComputeTotalValueBase
    {
        // Calculate the price for products that dont have any offer.
        public override decimal ComputeTotalValue(CartLine cartLine)
        {
            return cartLine.Product.Price.Amt * cartLine.Quantity;
        }
    }
}
