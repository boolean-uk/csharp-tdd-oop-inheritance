using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        public string name;
        public string contactInformation;
        public string website;

        public Author(string Name, string ContactInformation, string Website) 
        {
            this.name = Name;
            this.contactInformation = ContactInformation;
            this.website = Website;
        }

        public string getName()
        {
            return this.name;
        }
        public string getContactInformation()
        {
            return this.contactInformation;
        }
        public string getWebsite()
        {
            return this.website;
        }


    }
}
