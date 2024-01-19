using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : LibraryMaterial, IAuthorable
    {
        private IAuthor _author;
        private string _title;

        bool onLoan = false;


        public Article(string title, IAuthor author) : base(title)
        {
            this.title = title;
            _author = author;
        }
        public IAuthor Author { get => _author; set => _author = value; }
        public string Title { get => _title; set => _title = value; }
        
    }
}
