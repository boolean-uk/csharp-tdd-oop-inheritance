
public class Author {
    private string _name;
    private string _contactInformation;
    private string _website;

    public string Name { get { return _name; }}
    public string ContactInformation { get { return _contactInformation; }}
    public string Website { get { return _website; }}

    public Author(string name, string contact, string website) {
        _name = name;
        _contactInformation = contact;
        _website = website;
    }
}