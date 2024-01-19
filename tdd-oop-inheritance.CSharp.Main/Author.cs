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
        private string _telephone;
        private string _email;
        private string _website;
        public Author(string name, string telephone, string email, string website) {
            _name = name;
            _telephone = telephone;
            _email = email;
            _website = website;
        }
    }
}
