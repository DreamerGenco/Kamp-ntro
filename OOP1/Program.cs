using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 500;
            product.UnitsInStock = 3;

            Product product1 = new Product { Id = 2, 
                CategoryId = 5, UnitsInStock = 5, ProductName ="Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
        }
    }
}
