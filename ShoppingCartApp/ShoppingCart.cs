using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class ShoppingCart
    {

        private Product[] products;
        private int itemCount;

        public Product[] Products { get => products; }
        public int ItemCount { get => itemCount; }

        public ShoppingCart(int capacity)
        {
            products = new Product[capacity];
            itemCount = 0;
        }

        public void AddProduct(Product product)
        {
            if (itemCount < products.Length)
            {
                products[itemCount] = product;
                itemCount++;
            }
            else
            {
                Console.WriteLine("Shopping cart is full. Cannot add more products.");
            }
        }
        public void RemoveProduct(Product product)
        {
            int index = Array.IndexOf(products, product);
            if (index != -1)
            {
                Array.Copy(products, index + 1, products, index, itemCount - index - 1);
                itemCount--;
                products[itemCount] = null;
            }
            else
            {
                Console.WriteLine("Product not found in the shopping cart.");
            }
        }

        public void DisplayCart()
        {
            Console.WriteLine("Shopping Cart Contents:");
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"[{i + 1}] ");
                products[i].GetInfo();
            }
        }
    }
}


