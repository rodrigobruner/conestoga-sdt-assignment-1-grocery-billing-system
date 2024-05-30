namespace conestoga_software_development_technics_assignment_1_grocery_billing_system;

class Program
{

    static void Main(string[] args)
    {

        UI.SystemHeader();
        Inventory inventory = new Inventory();
        Product[] products = inventory.GetProducts();
        ShoppingCart shoppingCart = new ShoppingCart();
        ShowProductList(products);
        TakeOrder(products, shoppingCart);

        shoppingCart.hasLoyaltyCard = UI.YesNoField("Do you have our loyalty card?");
        shoppingCart.DisplayRecpit();
    }

    static void ShowProductList(Product[] products)
    {
        Console.WriteLine("See our product list below:\n");
        Console.WriteLine("Code | Product - Price");        
        foreach (Product product in products){
            Console.WriteLine(product.code + " | "+ product.name + " - CAD$" + product.price);
        }
        Console.WriteLine("\n");
    }

    static void TakeOrder(Product[] products, ShoppingCart shoppingCart)
    {
        int amount = 0;
        foreach (Product product in products){
            amount = UI.IntField($"Enter the quantity of {product.name} (0 for none):");
            shoppingCart.AddProduct(product, amount);
        }

    }
}
