using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;
using System.Net.Http.Headers;

namespace tdd_oop_inheritance.CSharp.Test
{
    class LibraryTest
    {
        private Library library;
        private Author author;

        [SetUp]
        public void SetUp()
        {
            this.library = new Library();
            this.author = new Author("AAA", "BBB", "CCC");
        }
        [Test]
        public void canAddAllTypesOfItemsToStock()
            {
                Article article = new Article("JUnit Rocks", author);
                Book book = new Book("example", author);
                Newspaper paper = new Newspaper("e2");

                library.addToStock(article);
                library.addToStock(book);
                library.addToStock(paper);

                List<LibraryItem> res = library.getItems();

                Assert.AreEqual(3, res.Count);
            }

        [Test]
        public void canCheckInAndCheckOutItem()
            {
                Article article = new Article("JUnit Rocks", author);
                library.addToStock(article);

                bool loaned = article.isOnLoan();
                Assert.IsFalse(loaned);

                library.checkOutLibraryItem("JUnit Rocks");

                loaned = article.isOnLoan();
                Assert.IsTrue(loaned);

                string result = library.checkOutLibraryItem("AAA");
                Assert.AreEqual("item is not part of the library's collection", result);

                library.checkInLibraryItem("JUnit Rocks");

                loaned = article.isOnLoan();
                Assert.IsFalse(loaned);

        }

    }
}