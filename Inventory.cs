using System.Reflection.Metadata.Ecma335;
/*
* this class is used to stores the products in the inventory
*/
public class Inventory{
    Product[] products; //list of products in the inventory

    //Constructor that creates the products in the inventory
    public Inventory()
    {
        products = new Product[5]; //initialize the list of products
        products[0] = new Product(1,"Apple", 2.75);
        products[1] = new Product(2,"Banana", 0.99);
        products[2] = new Product(3,"Orange", 2.50);
        products[3] = new Product(4,"Grape", 7.00);
        products[4] = new Product(5,"Watermelon", 8.00);
    }

    //Return the list of products because here is private
    public Product[] GetProducts()
    {
        return products;
    }
}