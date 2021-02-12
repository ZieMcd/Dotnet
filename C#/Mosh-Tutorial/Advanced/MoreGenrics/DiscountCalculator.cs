namespace MoreGenrics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product) 
        {
            return product.Price;  // we get access to all of Procucts (and any class that derives from it) propeties and methods 
        }
    }
}