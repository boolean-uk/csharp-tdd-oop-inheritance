using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        Library library;
        [Test]
        public void addToStockTest()
        {
            library = new Library();
            Book testBook = new Book("Roadside Picnic");
            Article testArticle = new Article("The Bronze Age Collapse");
            Newspaper testNewspaper = new Newspaper("Fake News");
            Assert.AreEqual(testBook, library.addToStock(testBook).ElementAt(0));
            Assert.AreEqual(testArticle, library.addToStock(testArticle).ElementAt(1));
            Assert.AreEqual(testNewspaper, library.addToStock(testNewspaper).ElementAt(2));
        }
    }
}