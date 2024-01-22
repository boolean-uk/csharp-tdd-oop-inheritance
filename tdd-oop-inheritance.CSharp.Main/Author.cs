using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tdd_oop_inheritance.CSharp.Main.Interfaces;
namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author : IAuthor
    {
        //private string _name;
        //private string _contactInfo;
        //private string _website;

        public Author(string name, string contactInfo, string website)
        {
            this.Name = name;
            this.ContactInfo = contactInfo;
            this.Website = website;
        }

        public string Name { get; set; }
        public string ContactInfo {  get; set; }
        public string Website { get; set; }
    }
}
