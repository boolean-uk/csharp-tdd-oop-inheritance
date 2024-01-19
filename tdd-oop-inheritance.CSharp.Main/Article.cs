using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : LibraryItem, IAuthorable
    {
        IAuthor _author;
        public Article(string title, IAuthor author = null) : base(title)
        {
            this._author = author;
        }

        public IAuthor Author { get { return _author; } set { _author = value; } }
    }
}
