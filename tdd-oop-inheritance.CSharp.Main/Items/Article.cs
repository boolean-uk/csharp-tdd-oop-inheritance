using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Author;

namespace Items
{
    public class Article : LibraryItem, IAuthorable
    {
        IAuthor _author;
        public Article(string title, IAuthor autohor) : base(title)
        {
            _author = autohor;
        }

        public IAuthor Author { get => _author; set => _author=value; }
    }
}

