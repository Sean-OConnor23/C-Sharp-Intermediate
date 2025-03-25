using Amazon;

namespace C_Sharp_Intermediate
{
    public class GoldCustomer : Customer1
    {
        public void OfferVoucher()
        {
            this.CalculateRating(true);
        }
    }
}
