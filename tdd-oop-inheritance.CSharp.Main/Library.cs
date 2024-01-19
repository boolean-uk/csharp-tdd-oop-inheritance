namespace tdd_oop_inheritance.CSharp.Main;

public class Library {
    List<Product> _products = new List<Product>();

    public void addToStock(Product item) {
        _products.Add(item);
    }

    // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
    // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
    public string checkInProduct(string title) {

        List<Product> filtered = _products.Where(article => article.title.Equals(title)).ToList();

        if (filtered.Count() < 1) {
            return "item is not part of the library's collection";
        }

        return filtered[0].checkIn();
    }

    public string checkOutProduct(string title) {
        List<Product> filtered = _products.Where(article => article.title.Equals(title)).ToList();

        if (filtered.Count() < 1) {
            return "item is not part of the library's collection";
        }

        return filtered[0].checkOut();
    }
}
