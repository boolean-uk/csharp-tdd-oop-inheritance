namespace tdd_oop_inheritance.CSharp.Main;

public class Article : Product
{
    private Author _author;

    public Article(string title, Author author) : base(title)
    {
        _author = author;
    }

    public Author Author { get { return _author; } }
}
