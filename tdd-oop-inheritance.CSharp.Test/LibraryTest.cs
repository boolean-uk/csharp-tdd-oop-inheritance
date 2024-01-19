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
        public void AddBookTest()
        {
            var library = new Library();
            var author = new Author("Famous Author", "Contact Info", "Author's Website");
            var book = new Book("Sample Book", author);

            library.addToStock(book);

            Assert.IsTrue(library.checkOutItem("Sample Book").Contains("checked out"));
        }

        [Test]
        public void AAddArticleTest()
        {
            var library = new Library();
            var author = new Author("Famous Author", "Contact Info", "Author's Website");
            var book = new Book("Sample Book", author);
            var article = new Article("Sample Article", author);

            library.addToStock(article);

            Assert.IsTrue(library.checkOutItem("Sample Article").Contains("checked out"));
        }

        [Test]
        public void AddNewsPaperTest()
        {
            var library = new Library();
            var newspaper = new Newspaper("Sample Newspaper");

            library.addToStock(newspaper);

            Assert.IsTrue(library.checkOutItem("Sample Newspaper").Contains("checked out"));
        }

        [Test]
        public void CheckInFalseItemTest()
        {
            var library = new Library();
            var result = library.checkInItem("Nonexistent Item");

            Assert.AreEqual("Item is not part of the library's collection", result);
        }

        [Test]
        public void CCheckOutFalseItemTest()
        {
            var library = new Library();
            var result = library.checkOutItem("Nonexistent Item");

            Assert.AreEqual("Item is not part of the library's collection", result);
        }
    }
}
