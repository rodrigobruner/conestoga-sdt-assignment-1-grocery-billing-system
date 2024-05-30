class ShoppingCart
{
    public double taxRate = 13.0;
    public double discountRate = 10.0;
    public bool hasLoyaltyCard=false;
    private List<CartItem> items;
    private double subtotal = 0;
    private double total = 0;
    private double discount = 0;
    private double tax = 0;

    public ShoppingCart()
    {
        items = new List<CartItem>();
    }

    public void AddProduct(Product product, int quantity)
    {
        if(quantity > 0) {
            items.Add(new CartItem(product, quantity));
        }
    }

    
    public void DisplayRecpit()
    {
        Console.Clear();
        UI.ShowSuccessMessages("Thank you for shopping with us!\n\n");
        Console.WriteLine("Your recpit is below:\n");
        Console.WriteLine("#----------------------------------#");
        Console.WriteLine("          List of items");
        Console.WriteLine("Product Item x amount");
        foreach (CartItem item in items)
        {
            Console.WriteLine(item.product.name + " x " + item.quantity);
            subtotal += item.product.price * item.quantity;
        }

        if (hasLoyaltyCard)
        {
            discount = subtotal * discountRate / 100;
        }
        tax = (subtotal - discount) * taxRate / 100;
        total = subtotal - discount + tax;

        Console.WriteLine("#----------------------------------#");
        Console.WriteLine("Subtotal: CAD$ " + subtotal.ToString("0.##"));
        Console.WriteLine("Discount: CAD$ " + discount.ToString("0.##"));
        Console.WriteLine("Tax: CAD$ " + tax.ToString("0.##"));
        Console.WriteLine("Total: CAD $" + total.ToString("0.##"));
        Console.WriteLine("#----------------------------------#\n\n");
    }
}