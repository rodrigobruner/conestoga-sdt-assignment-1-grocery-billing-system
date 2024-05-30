using System.Reflection.Metadata.Ecma335;

public class Inventory{
    Product[] products;
    public Inventory()
    {
        products = new Product[5];
        products[0] = new Product(1,"Apple", 2.75);
        products[1] = new Product(2,"Banana", 0.99);
        products[2] = new Product(3,"Orange", 2.50);
        products[3] = new Product(4,"Grape", 7.00);
        products[4] = new Product(5,"Watermelon", 8.00);
    }

    public Product[] GetProducts()
    {
        return products;
    }
}