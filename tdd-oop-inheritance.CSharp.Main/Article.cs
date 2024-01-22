using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Interfaces;
using tdd_oop_inheritance.CSharp.Main.Parentclass;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Literature
    {

        public Article(string title, IAuthor? author = null) : base(title, author)
        {
        }


        
    }
}
