using System;
#pragma warning disable IDE0005 // Using-Direktive ist unnötig.
using System.Collections.Generic;
using System.Text;
#pragma warning restore IDE0005 // Using-Direktive ist unnötig.

namespace OOP1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }


        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
    }
}
