/*
* This class is used to store the product and quantity of the product in the cart.
*/
class CartItem{
    // product in the cart
    public Product product;
    //quantit of the product in the cart
    public int quantity;

    // Constructor that initializes the product and quantity
    public CartItem(Product product, int quantity)
    {
        this.product = product;
        this.quantity = quantity;
    }
}