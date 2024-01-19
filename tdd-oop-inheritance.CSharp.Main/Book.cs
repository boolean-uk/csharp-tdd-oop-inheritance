using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Test;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Item
    {
        Author author;
        public Book(string title, Author author) : base(title)
        {
            this.author = author;
        }

        public List<string> getAuthorInfo()
        {
            List<string> info = new List<string>();
             info.Add(author.getName());
            info.Add(author.getContactInfo());
            info.Add(author.getWebsite());
            return info;
        }
    }
}
