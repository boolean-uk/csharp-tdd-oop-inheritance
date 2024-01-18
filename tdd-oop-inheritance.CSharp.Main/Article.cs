using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : ReadableItem {

        private Author Author;  // Composision: Author has fields
        public Article(string title, Author author) {
            Title = title;
            Author = author; // Dependency Injection: author is injected
        }

        public override string getInformation()
        {
            return base.getInformation() + $"\nAuthor: {Author.getName()}\nContact information: {Author.getContactInformation()}\nWebsite: {Author.getWebsite()}";
        }

    }
}
