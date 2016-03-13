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
            var totalAmount = products.ToList().Sum(p => p.Price);

            return totalAmount;
        }
    }
}