using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
    {
        public Author(string name = "", string email = "", string website = "")
        {
            AuthorName = name;
            AuthorEmail = email;
            AuthorWebsite = website;
        }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string AuthorWebsite { get; set; }

    }
}
