using Items;

public class Book : Item
{
    public Author Author { get; }
    public Book(string title, Author author) : base(title)
    {
        Author = author;
    }
}