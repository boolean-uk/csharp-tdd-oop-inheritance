using tdd_oop_inheritance.CSharp.Main;
using tdd_oop_inheritance.CSharp.Main.LibraryItems;

namespace LibraryItems
{
    public class Article(string title, Author author) : AuthorLibraryItem(title, author)
    {
    }
}
