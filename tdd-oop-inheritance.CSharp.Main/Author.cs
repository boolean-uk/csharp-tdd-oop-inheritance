using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author : IAuthor
    {
        //private string _name;
        //private string _contactInfo;
        //private string _website;
        //public Author(string name, string contactinfo, string website) 
        //{ 
        //    _name = name;
        //    _contactInfo = contactinfo;
        //    _website = website;
        //}
        //public string name { get { return _name; } set { _name = value; } }
        //public string contactinfo { get { return _contactInfo; } set { _contactInfo = value; } }
        //public string website { get { return _website; } set { _website = value; } }
        public Author(string name, string contact, string website) 
        {
            this.name = name;
            this.contactinfo = contact;
            this.website = website;
        }
        public string name { get; set; }
        public string contactinfo { get; set; }
        public string website { get; set; }
    }
}
