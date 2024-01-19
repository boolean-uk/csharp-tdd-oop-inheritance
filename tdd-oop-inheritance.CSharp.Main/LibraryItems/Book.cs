using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;
using tdd_oop_inheritance.CSharp.Main.LibraryItems;

namespace LibraryItems
{
    public class Book(string title, Author author) : AuthorLibraryItem(title, author)
    {

    }
}
