namespace tdd_oop_inheritance.CSharp.Main;

public class Newspaper : Product
{
    public Newspaper(string title) : base(title) {
    }

    public string checkIn() {
        return "newspapers are not available for loan";
    }

    public string checkOut() {
        return "newspapers are not available for loan";
    }
}
