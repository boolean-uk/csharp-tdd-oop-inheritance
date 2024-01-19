namespace tdd_oop_inheritance.CSharp.Main;

public class Book : Product
{
    private Author _author;

    public Book(string title, Author author) : base(title)
    {
        _author = author;
    }

    public Author Author { get { return _author; } }
}
