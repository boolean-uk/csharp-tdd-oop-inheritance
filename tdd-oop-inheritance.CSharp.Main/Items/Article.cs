using Items;

public class Article : Item
{
    public Author Author { get; }
    public Article(string title, Author author) : base(title)
    {
        Author = author;
    }
}