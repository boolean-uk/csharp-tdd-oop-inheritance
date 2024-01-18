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
            Author testAuthor = new Author("P.Adams", "04125636", "no");
            Author testAuthor2 = new Author("Dostoyevsky", "no", "no");
            library = new Library();
            Book testBook = new Book("Roadside Picnic", testAuthor2);
            Article testArticle = new Article("The Bronze Age Collapse", testAuthor);
            Newspaper testNewspaper = new Newspaper("Fake News");
            Assert.AreEqual(testBook, library.addToStock(testBook).ElementAt(0));
            Assert.AreEqual(testArticle, library.addToStock(testArticle).ElementAt(1));
            Assert.AreEqual(testNewspaper, library.addToStock(testNewspaper).ElementAt(2));
        }
    }
}