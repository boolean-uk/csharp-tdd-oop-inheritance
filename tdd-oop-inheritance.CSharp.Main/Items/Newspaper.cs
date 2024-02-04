using Items;

public class Newspaper : Item
{
    public Newspaper(string title) : base(title)
    {
    }

    public new string CheckIn()
    {
        return "Newspapers are not available for loan";
    }

    public new string CheckOut()
    {
        return "Newspapers are not available for loan";
    }
}