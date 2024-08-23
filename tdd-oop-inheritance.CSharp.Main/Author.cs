using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
   public class Author
    {
        public string Name { get; }
        public string Email { get; }
        public string Website { get; }

        public Author(string name, string email, string website)
        {
            this.Name = name;
            this.Email = email;
            this.Website = website;
        }   
    }
}
