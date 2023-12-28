using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class ProductService
    {
        private List<Product> products = new List<Product>();
        public void CreateProduct(Product product)
        {
            products.Add(product);
        }

        public int ProductsCount { get => products.Count; }

        public int ActiveProductsCount { get => products.Count(p => p.IsActive); }
        public Product GetProductMaxByPrice() => products.MaxBy(p => p.Price);
        public Product GetProductMinByPrice() => products.MinBy(p => p.Price);
        public decimal GetAveragePrice() => products.Average(p => p.Price);









    }
}
