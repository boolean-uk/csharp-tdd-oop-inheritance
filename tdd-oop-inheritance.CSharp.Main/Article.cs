using tdd_oop_inheritance.CSharp.Main.Interfaces;

namespace tdd_oop_inheritance.CSharp.Main;

public class Article : Product, IAuthorable
{
    private IAuthor _author;

    public Article(string title, IAuthor author) : base(title)
    {
        _author = author;
    }

    public IAuthor Author { get { return _author; } set { _author = value; } }
}
