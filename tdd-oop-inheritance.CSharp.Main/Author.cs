using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
{
        private string _name;
        private string _adress;
        private string _website;
        public Author(string name, string adress, string website)
        {
            _name = name;
            _adress = adress;
            _website = website;
        }

        public string Name { get { return _name; } }
        public string Adress { get { return _adress; } }
        public string Website { get { return _website; } }
                  

    }
}
