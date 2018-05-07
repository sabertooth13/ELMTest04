using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CheckOutService
    {

        public decimal Buy1Get1Total { get; set; }
        public decimal ThreeFor10Total { get; set; }
        public decimal NoOfferTotal { get; set; }
        public decimal Total { get; set; }
        public void CalcualteTotal(List<CartLine> cartLines)
        {
            decimal total;
            // seperate out each kind of prodcut from the orderlist and 
            // apply the promotional discount accordingly.


            CartLine productA = new CartLine();
            CartLine productB = new CartLine();
            CartLine productC = new CartLine();
            foreach (CartLine cartline in cartLines)
            {
                if (cartline.Product.Name == ProductType.A)
                {
                    productA = cartline;
                }
                if (cartline.Product.Name == ProductType.B)
                {
                    productB = cartline;
                }
                if (cartline.Product.Name == ProductType.c)
                {
                    productC = cartline;
                }
            }
            ComputeTotalValueBase computeTotalA = CartLineComputeTotalService.GetComputedPaymentFor(ProductType.A);
            Buy1Get1Total = computeTotalA.ComputeTotalValue(productA);
            ComputeTotalValueBase computeTotalB = CartLineComputeTotalService.GetComputedPaymentFor(ProductType.B);
            ThreeFor10Total = computeTotalB.ComputeTotalValue(productB);
            ComputeTotalValueBase computeTotalC = CartLineComputeTotalService.GetComputedPaymentFor(ProductType.c);
            NoOfferTotal = computeTotalC.ComputeTotalValue(productC);
            Total = Buy1Get1Total + ThreeFor10Total + NoOfferTotal;

        }

    }
}
