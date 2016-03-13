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
            //商品分組
            List<List<Product>> productGroups = GetProductGroups(products);

            //取得折扣
            SetDiscount(productGroups);

            var totalAmount = products.Sum(p => p.Price * p.Discount);

            return totalAmount;
        }

        private List<List<Product>> GetProductGroups(IEnumerable<Product> products)
        {
            List<List<Product>> productGroups = new List<List<Product>>();

            foreach (var product in products)
            {
                if (productGroups.Count == 0)
                {
                    productGroups.Add(new List<Product>() { product });
                }
                else
                {
                    List<Product> temp = null;
                    foreach (var group in productGroups)
                    {
                        if (group.Where(p => p.Name == product.Name).ToList().Count() == 0)
                        {
                            group.Add(product);
                            temp = null;
                            break;
                        }
                        else
                        {
                            temp = new List<Product>() { product };
                        }
                    }

                    if (temp != null)
                    {
                        productGroups.Add(temp);
                    }
                }
            }

            return productGroups;
        }

        private void SetDiscount(List<List<Product>> productGroups)
        {
            foreach (var group in productGroups)
            {
                double discount = GetDisCount(group.Count());
                foreach (var product in group)
                {
                    product.Discount = discount;
                }
            }
        }

        private double GetDisCount(int volumeCount)
        {
            switch (volumeCount)
            {
                case 2:
                    return 0.95;
                    break;

                case 3:
                    return 0.9;
                    break;

                case 4:
                    return 0.8;
                    break;

                case 5:
                    return 0.75;
                    break;

                default:
                    return 1;
                    break;
            }
        }
    }
}