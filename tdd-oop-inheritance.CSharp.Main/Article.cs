using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : LibraryItem 
    {
        //Slightly modified to enherit from LibraryClass, and have author as property
        public Author author { get; set; }
        public Article(string title) : base(title) 
        {
            
        }
    }
}
