/*
* this class is responsible for creating a product
*/
public class Product{
    //product code
    public int code;
    //product name
    public string ?name;
    //product price
    public double price;

    //constructor that initialize the product
    public Product(int code, string name, double price)
    {
        if (code > 0 && name != null && price >= 0){ // validate the product info
            this.code = code;
            this.name = name;
            this.price = price;  
        } else {
            UI.ShowErrorMessages("Invalid product, please try again");
        }
    }
}