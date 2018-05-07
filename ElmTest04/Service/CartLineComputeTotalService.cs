using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CartLineComputeTotalService
    {
        // Factory Method to instanciate the object at runtime.
        public static ComputeTotalValueBase GetComputedPaymentFor(ProductType productName)
        {
            switch (productName)
            {
                case ProductType.A:
                    return new ComputeBuy1Get1();
                case ProductType.B:
                    return new Compute3For10();
                case ProductType.c:
                default:
                    return new ComputeTotal();
            }
        }


    }
}
