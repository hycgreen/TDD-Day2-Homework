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
            switch (potterVolCount)
            {
                case 2:
                    discount = 0.95;
                    break;

                case 3:
                    discount = 0.9;
                    break;

                case 4:
                    discount = 0.8;
                    break;

                case 5:
                    discount = 0.75;
                    break;
            }

            var totalAmount = products.Sum(p => p.Price * discount);

            return totalAmount;
        }
    }
}