using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        [Test]

        public void TestAddNewspaperToStock()
        {
            Library library = new Library();
            Newspaper newspaper = new Newspaper("Aftenpoften 1");
            library.addToStock(newspaper);

            Assert.AreEqual(library.catalog.Count, 1);

        }
        [Test]

        public void TestAddBookToStock()
        {
            Library library = new Library();
            Book book = new Book("Return of the king");
            library.addToStock(book);

            Assert.AreEqual(library.catalog.Count, 1);

        }
        [Test]
        public void TestAddArticleToStock()
        {
            Library library = new Library();
            Article article = new Article("Good article written by scientist");
            library.addToStock(article);

            Assert.AreEqual(library.catalog.Count, 1);

        }

        [Test]

        public void TestCheckInItemThatIsNotInCatalog()
        {
            Library library = new Library();
            Article article = new Article("Good article written by scientist");
            Book book = new Book("Return of the Kung");
            library.addToStock(book);

            Assert.AreEqual("item is not part of the library's collection", library.checkInItem("Good article written by scientist"));

        }
        [Test]
        public void TestCheckInItemThatIsInCatalog()
        {
            Library library = new Library();
            Book book = new Book("Return of the Kung");
            library.addToStock(book);

            Assert.AreEqual("item is not currently on loan", library.checkInItem("Return of the Kung"));

        }
        [Test]
        public void TestCheckOutItemThatIsNotInCataLog()
        {
            Library library = new Library();
            Book book = new Book("Return of the Kung");

            Assert.AreEqual("item is not part of the library's collection", library.checkOutItem("Return of the Kung"));

        }
        [Test]
        public void TestCheckOutItemThatIsInCataLog()
        {
            Library library = new Library();
            Book book = new Book("Return of the Kung");
            library.addToStock(book);

            Assert.AreEqual("item has been checked out", library.checkOutItem("Return of the Kung"));

        }
    }
}
