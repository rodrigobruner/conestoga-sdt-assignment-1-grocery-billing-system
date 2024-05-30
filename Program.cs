namespace conestoga_software_development_technics_assignment_1_grocery_billing_system;
/*
* this class is used to run the system
*/
class Program
{

    static void Main(string[] args)
    {

        UI.SystemHeader(); // show the systemHeader
        Inventory inventory = new Inventory(); //create the inventory 
        Product[] products = inventory.GetProducts(); //get all products from the inventory
        ShoppingCart shoppingCart = new ShoppingCart(); // create the shopping cart
        ShowProductList(products); // show all products in the inventory
        TakeOrder(products, shoppingCart); //takes the order from the user

        shoppingCart.hasLoyaltyCard = UI.YesNoField("Do you have our loyalty card?");
        shoppingCart.DisplayRecpit();
    }

    //show all products in the list
    static void ShowProductList(Product[] products)
    {
        Console.WriteLine("See our product list below:\n");
        Console.WriteLine("Code | Product - Price");        
        foreach (Product product in products){ //for each product in the list
            Console.WriteLine(product.code + " | "+ product.name + " - CAD$" + product.price);
        }
        Console.WriteLine("\n");
    }

    //take the order from the user
    static void TakeOrder(Product[] products, ShoppingCart shoppingCart)
    {
        int amount = 0;
        foreach (Product product in products){ //for each product in the list
            amount = UI.IntField($"Enter the quantity of {product.name} (0 for none):"); //ask the user for the amount 
            shoppingCart.AddProduct(product, amount); // add the product to the shopping cart
        }
    }
}
