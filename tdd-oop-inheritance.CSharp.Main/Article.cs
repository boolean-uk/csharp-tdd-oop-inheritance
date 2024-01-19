using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Literature 
    {
        Author author;
        public Article(string title, Author author) : base(title) 
        {
            this.author = author;
        }
       public Author Author
        {
            get { return author; } }
    }
}
