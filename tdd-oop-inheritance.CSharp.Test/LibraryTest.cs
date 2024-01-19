using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryTest
{
        [Test]
        public void addToStockTest()
        {
            //arrange
            Library library = new Library();
            IAuthor author = new Author("J. R. R Tolkien", "tolkien.email.com", "tolkien.com");
            Item book = new Book("Lord of the rings", author);

            //act
            library.addToStock(book);

            //assert
            Assert.IsTrue(library.items.Count > 0);
            
        }

        [Test]
        public void checkInItemTest()
        {
            //arrange
            Library library = new Library();
            IAuthor author = new Author("J. R. R Tolkien", "tolkien.email.com", "tolkien.com");
            Item book = new Book("Lord of the rings", author);
            library.addToStock(book);

            //act
            string result = library.checkInItem("Lord of the rings");

            //assert
            Assert.AreEqual("item is not currently on loan", result);
        }

        [Test]
        public void checkOutItemTest() 
        {
            //arrange
            Library library = new Library();
            IAuthor author = new Author("J. R. R Tolkien", "tolkien.email.com", "tolkien.com");
            Item book = new Book("Lord of the rings", author);
            library.addToStock(book);

            //act
            string result = library.checkOutItem("Lord of the rings");

            //assert
            Assert.AreEqual("item has been checked out", result);
        }

    }
}
