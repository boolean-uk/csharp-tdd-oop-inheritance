using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Library {

        Author author;

        public Book(string title, string authorName, string email, string website) {
            this.title = title;
            author = new Author(authorName, email, website);
        }
    }
}
