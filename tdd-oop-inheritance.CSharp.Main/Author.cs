using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;
using NuGet.Frameworks;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class Author
    {
        private string name {  get; set; }
        private string contactInfo {  get; set; }
        private string website {  get; set; }

        public Author(string name, string contactInfo, string website)
        {
            this.name = name;
            this.contactInfo = contactInfo;
            this.website = website;
        }

        public string getName()
        {
            return name;
        }
        public string getContactInfo()
        {
            return contactInfo;
        }
        public string getWebsite()
        {
            return website;
        }


    }
}