using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    class ArticleTest
    {
        [Test]
        public void ShouldCheckOutIfAvailable()
        {
            Author author = new Author("John Doe", "john@example.com", "www.example.com");
            Article article = new Article("JUnit Rocks", author);

            Assert.AreEqual("Item has been checked out!", article.CheckOut());
        }

        [Test]
        public void ShouldDeclineIfNotAvailableToCheckout()
        {
            Author author = new Author("John Doe", "john@example.com", "www.example.com");
            Article article = new Article("JUnit Rocks", author);
            article.CheckOut();

            Assert.AreEqual("Item is currently on loan!", article.CheckOut());
        }

        [Test]
        public void ShouldCheckInIfOnLoan()
        {
            Author author = new Author("John Doe", "john@example.com", "www.example.com");
            Article article = new Article("JUnit Rocks", author);
            article.CheckOut();

            Assert.AreEqual("Item has been checked in!", article.CheckIn());
        }

        [Test]
        public void ShouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new Author("John Doe", "john@example.com", "www.example.com");
            Article article = new Article("JUnit Rocks", author);

            Assert.AreEqual("Item is not currently on loan!", article.CheckIn());
        }
    }
}