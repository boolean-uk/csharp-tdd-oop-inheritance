using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author author = new Author("John Smith", "smith@mail.com", "Smith.com");
            Article article = new Article("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", article.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author author = new Author("John Smith", "smith@mail.com", "Smith.com");
            Article article = new Article("JUnit Rocks", author);
            article.checkOut();

            Assert.AreEqual("item is currently on loan", article.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author author = new Author("John Smith", "smith@mail.com", "Smith.com");
            Article article = new Article("JUnit Rocks", author);
            article.checkOut();

            Assert.AreEqual("item has been checked in", article.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new Author("John Smith", "smith@mail.com", "Smith.com");
            Article article = new Article("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", article.checkIn());
        }

        [Test]
        public void CheckForAuthorName()
        {
            Author author = new Author("John Smith", "smith@gmail.com", "smith.com");
            Article article = new Article ("JUnit Rocks", author);

            string name = article.author.name;

            Assert.That("John Smith", Is.EqualTo(name));
        }

        [Test]
        public void CheckForAuthor()
        {
            Author author = new Author("John Smith", "smith@gmail.com", "smith.com");
            Article article = new Article("JUnit Rocks", author);

            Assert.That(author, Is.EqualTo(article.author));
        }
    }
}