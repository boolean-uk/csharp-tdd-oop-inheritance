using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : LibraryItem
    {
        public Author author; 
        public Book(string title, Author author) : base(title)
        {
            this.title = title;
            this.author = author;
        }

        public override string ToString()
        {
            return $"{this.title} {this.author.name} {this.author.contactInformation} {this.author.website}";
        }
    }
}
