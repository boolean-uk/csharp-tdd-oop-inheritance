using LibraryItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main.LibraryItems
{
    public abstract class AuthorLibraryItem : LibraryItem
    {
        public Author Author { get; }
        protected AuthorLibraryItem(string title, Author author) : base(title)
        {
            Author = author;
        }
    }
}
