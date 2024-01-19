namespace tdd_oop_inheritance.CSharp.Main;
public class Author
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
    public string Email { get { return _email; } }
    public string Website { get { return _website; } }
}