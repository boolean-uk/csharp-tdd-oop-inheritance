using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        private string name;
        private string contactInfo;
        private string website;
        public Author(string name, string contactInfo, string website) 
        {
            this.name = name;
            this.contactInfo = contactInfo; 
            this.website = website;
        } 
        public string Name { get { return name; } } 
        public string ContactInfo { get {  return contactInfo; } }
        public string Website { get {  return website; } }
    }
}
