public class Product{

    public int code;
    public string ?name;
    public double price;

    public Product(int code, string name, double price)
    {
        if (code > 0 && name != null && price >= 0){
            this.code = code;
            this.name = name;
            this.price = price;  
        } else {
            UI.ShowErrorMessages("Invalid product, please try again");
        }
    }
}