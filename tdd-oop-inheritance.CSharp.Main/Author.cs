using tdd_oop_inheritance.CSharp.Main.Interfaces;

namespace tdd_oop_inheritance.CSharp.Main;
public class Author : IAuthor
{
    private string _name;
    private string _email;
    private string _website;

    public Author(string name, string email, string website)
    {
        _name = name;
        _email = email;
        _website = website;
    }

    public string Name { get { return _name; } }
    public string Email { get { return _email; } set { _email = value; } }
    public string Website { get { return _website; } set { _email = value; } }
}