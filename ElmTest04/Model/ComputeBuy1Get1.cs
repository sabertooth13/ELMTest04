using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ComputeBuy1Get1 : ComputeTotalValueBase
    {

        // Apply the Offer to the items that we brought for Buy 1 get 1 offer.
        // if we buy more produts than allowed in the offer , each extra product
        // will be charged indivudually
        public override decimal ComputeTotalValue(CartLine cartLine)
        {
            if (cartLine.Quantity >= 2)
            {
                if (cartLine.Quantity % 2 != 0)
                {
                    return Convert.ToDecimal((cartLine.Quantity / 2) * cartLine.Product.Price.Amt) + cartLine.Product.Price.Amt;
                }
                else
                {
                    return Convert.ToDecimal((cartLine.Quantity / 2) * cartLine.Product.Price.Amt);
                }
            }
            else
            {
                return cartLine.Quantity * cartLine.Product.Price.Amt;
            }

        }
    }
}
