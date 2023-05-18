using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Interface;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author : IAuhtor
    {
        public string Name { get ; set ; }
        public string _website { get; set; }
        public string _conntactInfo { get; set; }
        public Author(string name,string website, string contact) {
        
            Name = name;
            _website = website;
            _conntactInfo = contact;

        }
    }
}
