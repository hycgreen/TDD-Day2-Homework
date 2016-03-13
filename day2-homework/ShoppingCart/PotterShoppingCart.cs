using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class PotterShoppingCart
    {
        public PotterShoppingCart()
        {

        }

        public double Sum(IEnumerable<Product> products)
        {
            var potterVolCount = products.GroupBy(p => p.Name).Count();

            double discount = 1;
            if (potterVolCount == 2)
            {
                discount = 0.95;
            }

            var totalAmount = products.Sum(p => p.Price * discount);

            return totalAmount;
        }
    }
}