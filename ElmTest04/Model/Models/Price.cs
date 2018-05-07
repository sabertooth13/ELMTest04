using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
   public class Price
    {
        private decimal _amt;
        public decimal Amt
        {
            get { return _amt; }
            set { Amt = value; }
        }
        private OfferType _offerType;

        private IOfferStratergy _offerStratergy;
        public Price(decimal price)
        {
            _amt = price;
        }

        public void SetOfferStratergyTo(IOfferStratergy offerStratergy)
        {
            _offerStratergy = offerStratergy;
        }
        public OfferType OfferType
        {
            get { return _offerStratergy.ApplyDiscountTo(_offerType); }
        }
    }
}
