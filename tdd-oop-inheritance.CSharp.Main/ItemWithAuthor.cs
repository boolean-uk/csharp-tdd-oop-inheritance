using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main

{
    public class ItemWithAuthor : Item

    {
        public Author author;
        public ItemWithAuthor(string title, Author author): base(title)
        {
            this.title = title;
            this.author = author;
        }


    }
}
