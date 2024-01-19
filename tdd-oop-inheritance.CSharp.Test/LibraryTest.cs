using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    class LibraryTest
    {
        private Library library;
        private LibraryItem itemBook;
        private LibraryItem itemArticle;
        private LibraryItem itemNewspaper;


        [SetUp] 
        public void SetUp() 
        {
        library = new Library();
        itemBook = new Book("HarryPotter");
        itemArticle = new Article("BigScandal");
        itemNewspaper = new Newspaper("DailyNews");
        }

        [Test]

        public void shouldAddItem() 
        {
            library.addToStock(itemBook);

            Assert.Contains(itemBook, library.libraryItems);
        }
        [Test]
        public void checkInItemTest() 
        {
            library.addToStock(itemBook);
            library.addToStock(itemArticle);
            library.addToStock(itemNewspaper);

            Assert.AreEqual("item is not currently on loan", library.checkInItem("HarryPotter"));
            Assert.AreEqual("item is not currently on loan", library.checkInItem("BigScandal"));
            Assert.AreEqual("newspapers are not available for loan", library.checkInItem("DailyNews"));

            Assert.AreEqual("item is not part of the library's collection", library.checkInItem("DailyNews37"));
        }
        [Test]
        public void checkOutItemTest() 
        {
            library.addToStock(itemBook);
            library.addToStock(itemArticle);
            library.addToStock(itemNewspaper);

            Assert.Contains(itemBook, library.libraryItems);

            Assert.AreEqual("item has been checked out", library.checkOutItem("HarryPotter"));
            Assert.AreEqual("item has been checked out", library.checkOutItem("BigScandal"));
            Assert.AreEqual("newspapers are not available for loan", library.checkOutItem("DailyNews"));

            Assert.AreEqual("item is not part of the library's collection", library.checkInItem("DailyNews37"));
        }
    }
}
