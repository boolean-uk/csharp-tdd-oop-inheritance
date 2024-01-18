using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance;

namespace tdd_oop_inheritance.CSharp.Main
{
 


    public class Author
    {

        private string Name;
        private string ContactInfo;
        private string website;

        public Author(string Name, string ContactInfo, string webstite) 
        { 
            this.Name = Name;   
            this.ContactInfo = ContactInfo;
            this.website = webstite;
        }


        public string getName()
        { 
            return this.Name;
        }
        public string getContactInfo() 
        {
            return this.ContactInfo;
        }

        public string getWebsite() 
        {
            return website;    
        }
    }
}
