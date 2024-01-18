using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        [Test]
        public void CheckItems()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Book book = new Book("Throne of Glass");
            Article article = new Article("CandyHouse");
            
            Library library = new Library();
            library.items.Add(newspaper);
            library.items.Add(book);
            library.items.Add(article);

            Assert.AreEqual(3, library.items.Count());
        }

        [Test]
        public void ShouldBeCheckedIn()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Book book = new Book("Throne of Glass");
            Article article = new Article("CandyHouse");

            Library library = new Library();
            library.items.Add(newspaper);
            library.items.Add(book);
            library.items.Add(article);

            Assert.AreEqual("item has been checked out", library.checkOutItem("Throne of Glass"));
        }
    }
}