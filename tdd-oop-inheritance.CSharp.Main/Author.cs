namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string WebsiteUrl { get; set; }

        public Author(string name, string contactInfo, string websiteUrl)
        {
            Name = name;
            ContactInfo = contactInfo;
            WebsiteUrl = websiteUrl;
        }
    }
}
