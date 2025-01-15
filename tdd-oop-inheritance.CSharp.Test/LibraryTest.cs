using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        [Test]
        public void testCheckInItem()
        {
            Library library = new Library();
            Article article = new Article("article");
            library.addToStock(article);
            library.checkOutItem("article");
            Assert.AreEqual("item has been checked in", library.checkInItem("article"));
        }
        [Test]
        public void testCheckOutItem()
        {
            Library library = new Library();
            Article article = new Article("article");
            library.addToStock(article);
            Assert.AreEqual("item has been checked out", library.checkOutItem("article"));
        }

        [Test]
        public void testCheckInItemNotInStock()
        {
            Library library = new Library();
            Assert.AreEqual("item is not part of the library's collection", library.checkInItem("article"));
        }
        [Test]
        public void testCheckOutItemNotInStock()
        {
            Library library = new Library();
            Assert.AreEqual("item is not part of the library's collection", library.checkOutItem("article"));
        }
        [Test]
        public void testAddToStock()
        {
            Library library = new Library();
            Article article = new Article("wondeful article");
            library.addToStock(article);
            Assert.AreEqual(1, library.items.Count);
        }

        [Test]
        public void testGetItemsByAuthor()
        {
            Library library = new Library();
            Article article = new Article("Why see sharp");
            Author author1 = new Author("Nigel", "nigel@boolean.com", "boolean.com");
            Author author2 = new Author("Dave", "dave@boolean.com", "boolean.com");
            article.Author = author1;
            library.addToStock(article);

            for (int i = 0; i < 5; i++)
            {
                Book book = new Book("See sharp volume "+ i);
                book.Author = author1;
                library.addToStock(book);
            }

            for (int i = 0; i < 5; i++)
            {
                Book book = new Book("Getting to know Jawas volume " + i);
                book.Author = author2;
                library.addToStock(book);
            }

            List<LibraryItem> items = library.GetItemsByAuthor("Nigel");
            Assert.AreEqual(6, items.Count);
            Assert.AreEqual("Why see sharp", items[0].title);
            List<Book> nigelBooks = items.Where(x => x is Book).Cast<Book>().ToList();
            Assert.AreEqual(5, nigelBooks.Count);
        }
    }
}
