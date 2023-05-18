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
        Library library = new Library();
        [Test]
        public void checkAdd()
        {
            Book book = new Book("MyBook", new Author("Iasonas", "boolean", "Greece"));
            Newspaper news = new Newspaper("News");
            Article article = new Article("Article", new Author("Nigel", "boolean", "Uk"));
            library.addToStock(book);
            library.addToStock(news);
            library.addToStock(article);
            Assert.AreEqual(library.articles.Count, 1);
            Assert.AreEqual(library.newspapers.Count, 1);
            Assert.AreEqual(library.books.Count, 1);
        }

        [Test]
        public void checkInArticleTest()
        {
            Assert.AreEqual(library.checkInArticle("Article"), "item is not currently on loan");
        }

        [Test]
        public void checkOutArticleTest()
        {
            Assert.AreEqual(library.checkOutArticle("Article"), "item has been checked out");
        }

        [Test]
        public void checkInBookTest()
        {
            Assert.AreEqual(library.checkInBook("MyBook"), "item is not currently on loan");
        }

        [Test]
        public void checkOutBookTest()
        {
            Assert.AreEqual(library.checkOutBook("MyBook"), "item has been checked out");
        }

        [Test]
        public void checkInNewsTest()
        {
            Assert.AreEqual(library.checkInNewspaper("News"), "newspapers are not available for loan");
        }

        [Test]
        public void checkOutNewsTest()
        {
            Assert.AreEqual(library.checkOutNewspaper("News"), "newspapers are not available for loan");
        }

        [Test]
        public void checkBookAuthor()
        {
            Assert.AreEqual(library.bookAuthorExist("Iasonas"), true);
        }

        [Test]
        public void checkArticleAuthor()
        {
            Assert.AreEqual(library.articleAuthorExist("Nigel"), true);
        }

        [Test]
        public void checkBookSearchByAuthor()
        {
            Assert.AreEqual(library.searchBookByAuthor("Iasonas"), "MyBook");
        }

        [Test]
        public void checkArticleSearchByAuthor()
        {
            Assert.AreEqual(library.searchArticleByAuthor("Nigel"), "Article");
        }
    }
}
