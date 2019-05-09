using OrderTaker.SharedObjects;
using System.Collections.Generic;

namespace OrderTaker.Data
{
    public static class Products
    {
        public static List<Product> GetProducts()
        {
            var p = new List<Product>()
            {
                new Product() { ProductId = 1, ProductName = "Universal Translator",
                                Price = 199.99M },
                new Product() { ProductId = 2, ProductName = "Captain's Chair (Vinyl)",
                                Price = 549.99M },
                new Product() { ProductId = 3, ProductName = "Captain's Chair (Leather)",
                                Price = 2999.99M },
                new Product() { ProductId = 4, ProductName = "Laser Beacon",
                                Price = 99.95M },
                new Product() { ProductId = 5, ProductName = "Space Suit",
                                Price = 599.99M },
                new Product() { ProductId = 6, ProductName = "Warp Engine",
                                Price = 1599.99M },
                new Product() { ProductId = 7, ProductName = "Moonbase",
                                Price = 2999999.99M },
                new Product() { ProductId = 8, ProductName = "Starship",
                                Price = 5999999.99M },
                new Product() { ProductId = 9, ProductName = "Name Badge: John",
                                Price = 0.99M },
                new Product() { ProductId = 10, ProductName = "Name Badge: Dante",
                                Price = 0.99M },
                new Product() { ProductId = 11, ProductName = "Name Badge: Isaac",
                                Price = 0.99M },
            };
            return p;
        }
    }
}
