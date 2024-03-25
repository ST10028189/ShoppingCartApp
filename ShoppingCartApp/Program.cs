namespace ShoppingCartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClothingProduct clothingProduct = new ClothingProduct("Skirt", 179.99, ProductCategory.Clothing, "M", "Black");
            ElectronicsProduct electronicsProduct = new ElectronicsProduct("Laptop", 16999.99, ProductCategory.Electronics, "Asus", "Tuff");
            ShoppingCart cart = new ShoppingCart(5);

            cart.AddProduct(clothingProduct);
            cart.AddProduct(electronicsProduct);

            Console.WriteLine("Cart Contents:");
            cart.DisplayCart();

            cart.RemoveProduct(clothingProduct);

            Console.WriteLine("Updated Cart:");
            cart.DisplayCart();
        }
    }
}