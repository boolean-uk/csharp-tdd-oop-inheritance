using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Literature, IAuthor
    {
        private Author _author;
        public Article(string title) : base(title)
        {
            _title = title;
        }

        public void SetAuthor(string name, string number, string email)
        {
            _author = new Author(name, number, email);
        }

        public Author GetAuthor()
        {
            return _author;
        }
    }
}
