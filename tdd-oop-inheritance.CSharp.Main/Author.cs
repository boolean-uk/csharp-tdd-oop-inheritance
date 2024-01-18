using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
   public class Author
   {
        private string _name, _contact, _website;   
        public Author(string name, string contact, string website) {
            this._name = name;
            this._contact = contact;
            this._website = website;
        }
   }
}
