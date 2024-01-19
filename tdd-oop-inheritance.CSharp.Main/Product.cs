namespace tdd_oop_inheritance.CSharp.Main;

public class Product
{
    public string title;

    bool onLoan = false;

    public Product(string title)
    {
        this.title = title;
    }

    public bool isOnLoan()
    {
        return onLoan;
    }

    public string checkIn()
    {
        if (!isOnLoan())
        {
            return "item is not currently on loan";
        }

        onLoan = false;

        return "item has been checked in";
    }

    public string checkOut()
    {
        if (isOnLoan())
        {
            return "item is currently on loan";
        }

        onLoan = true;

        return "item has been checked out";
    }
}