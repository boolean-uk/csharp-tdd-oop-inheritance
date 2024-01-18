namespace tdd_oop_inheritance.CSharp.Main
{

    public class Author
    {
        public string Name { get; private set; }
        public string ContactInfo { get; private set; }
        public string Website { get; private set; }

        public Author(string name , string contactInfo , string website)
        {
            Name = name;
            ContactInfo = contactInfo;
            Website = website;
        }
    }
}
