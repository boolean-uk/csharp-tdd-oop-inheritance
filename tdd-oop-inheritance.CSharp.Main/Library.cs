using Items;

public class Library
{
    public List<Item> items = new List<Item>();

    public void AddToStock(Item item)
    {
        items.Add(item);
    }

    public string CheckInOut<T>(string title, bool checkOut) where T : Item
    {
        if (typeof(T) == typeof(Newspaper))
        {
            return "Newspapers are not available for loan";
        }

        T item = items.OfType<T>().FirstOrDefault(i => i.Title.Equals(title));

        if (item == null)
        {
            return "Item is not part of the library's collection";
        }

        return checkOut ? item.CheckOut() : item.CheckIn();
    }
}