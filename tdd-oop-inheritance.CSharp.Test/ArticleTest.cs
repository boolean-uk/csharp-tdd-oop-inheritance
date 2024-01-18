using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Article article = new Article("JUnit Rocks", "Bengt", "12395231", "website.bengt.com");
            Assert.AreEqual("item has been checked out", article.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Article article = new Article("JUnit Rocks", "Bengt", "12395231", "website.bengt.com");
            article.checkOut();

            Assert.AreEqual("item is currently on loan", article.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Article article = new Article("JUnit Rocks", "Bengt", "12395231", "website.bengt.com");
            article.checkOut();

            Assert.AreEqual("item has been checked in", article.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Article article = new Article("JUnit Rocks", "Bengt", "12395231", "website.bengt.com");

            Assert.AreEqual("item is not currently on loan", article.checkIn());
        }

        [Test]
        public void containsAuthor()
        {
            Article article = new Article("JUnit Rocks", "Bengt", "12395231", "website.bengt.com");
            Assert.That(article.Name, Is.EqualTo("Bengt"));
        }
    }
}