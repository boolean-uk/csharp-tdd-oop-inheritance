using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author {

        public string name { get;  }
        public string contactInformation {  get; }
        public string website { get; }

        public Author(string name, string contactInformation, string website)  {
           
            this.name = name;
            this.contactInformation = contactInformation;
            this.website = website;
        }

    }
}
