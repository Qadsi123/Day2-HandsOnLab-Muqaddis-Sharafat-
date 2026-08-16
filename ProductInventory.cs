using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
class ProductInventory
{
    public static void Show()
    {
        List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 80000 },
            new Product { Id = 2, Name = "Mouse", Category = "Electronics", Price = 2000 },
            new Product { Id = 3, Name = "Chair", Category = "Furniture", Price = 15000 },
            new Product { Id = 4, Name = "Keyboard", Category = "Electronics", Price = 5000 },
            new Product { Id = 5, Name = "Desk", Category = "Furniture", Price = 25000 }
        };
        var affordableProducts = products.Where(p => p.Price < 20000);

        Console.WriteLine("Products under 20000:");

        foreach (var product in affordableProducts)
        {
            Console.WriteLine(product.Name + " - " + product.Price);
        }
        var sortedProducts = products.OrderBy(p => p.Price);

        Console.WriteLine("\nProducts sorted by price:");

        foreach (var product in sortedProducts)
        {
            Console.WriteLine(product.Name + " - " + product.Price);
        }
        var productFound = products.FirstOrDefault(p => p.Name == "Laptop");

        Console.WriteLine("\nSearch Result:");

        if (productFound != null)
        {
            Console.WriteLine(productFound.Name + " - " + productFound.Price);
        }
        var productNames = products.Select(p => p.Name);

        Console.WriteLine("\nProduct Names:");

        foreach (var name in productNames)
        {
            Console.WriteLine(name);
        }
    }
}