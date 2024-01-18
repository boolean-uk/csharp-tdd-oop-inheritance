namespace tdd_oop_inheritance.CSharp.Main
{
    public class ItemWithAuthor : Item
    {
        public string Name { get; }
        public string ContactInfo { get; }
        public string Website { get; }

        protected ItemWithAuthor(string title, string name, string contactInfo, string website) : base(title)
        {
            this.Name = name;
            this.ContactInfo = contactInfo;
            this.Website = website;
        }
    }
}
