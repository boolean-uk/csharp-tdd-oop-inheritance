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
        private string email;
        private string website;

        public Author(string name = "Unknown", string email = "", string website = "")
        {
            this.name = name;
            this.email = email;
            this.website = website;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Website { get => website; set => website = value; }
    }
}
