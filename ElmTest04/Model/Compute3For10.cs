using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Compute3For10 : ComputeTotalValueBase
    {

        // Apply the Offer to the items that we brought for 3for10 offer.
        // if we buy more produts than allowed in the offer , each extra product
        // will be charged indivudually

        public override decimal ComputeTotalValue(CartLine cartLine)
        {
            if (cartLine.Quantity >= 3)
            {
                if (cartLine.Quantity % 3 != 0)
                {
                    int qutnt = (int)cartLine.Quantity / 3;
                    int remaindr = (int)(cartLine.Quantity % 3);
                    return (qutnt * 10) + (remaindr * cartLine.Product.Price.Amt);
                }
                else
                {
                    return (cartLine.Quantity / 3) * 10;
                }
            }
            else
            {
                return cartLine.Quantity * cartLine.Product.Price.Amt;
            }
        }
    }
}
