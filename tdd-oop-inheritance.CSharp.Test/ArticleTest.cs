using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author author = new Author("John", "1234", "www.john.com");
            Article article = new Article("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", article.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author author = new Author("John", "1234", "www.john.com");
            Article article = new Article("JUnit Rocks", author);
            article.checkOut();

            Assert.AreEqual("item is currently on loan", article.checkOut());
         }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author author = new Author("John", "1234", "www.john.com");
            Article article = new Article("JUnit Rocks", author);
            article.checkOut();

            Assert.AreEqual("item has been checked in", article.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new Author("John", "1234", "www.john.com");
            Article article = new Article("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", article.checkIn());
        }

        [Test]
        public void ArticleHasAuthorGiven()
        {
            Author author = new Author("John", "1234", "www.john.com");
            Article article = new Article("JUnit Rocks", author);

            Assert.That(article.Author, Is.Not.Null);
            Assert.That(article.Author.Name == "John", Is.True);
            Assert.That(article.Author.ContactInformation == "1234", Is.True);
            Assert.That(article.Author.Website == "www.john.com", Is.True);
        }
    }
}