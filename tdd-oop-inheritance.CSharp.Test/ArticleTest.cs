using NUnit.Framework;
using Items;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        private Author author; 
        private Article article;

        [SetUp]
        public void SetUp()
        {
            author = new Author("Dan Brown", "dan@brown.com", "www.danbrown.com");
            article = new Article("JUnit Rocks", author);
        }

        [Test]
        public void ShouldCheckOutIfAvailable()
        {
            Assert.That(article.CheckOut(), Is.EqualTo("Item has been checked out"));
        }

        [Test]
        public void ShouldDeclineIfNotAvailableToCheckout()
        {
            article.CheckOut();
            Assert.That(article.CheckOut(), Is.EqualTo("Item is currently on loan"));
        }

        [Test]
        public void ShouldCheckInIfOnLoan()
        {
            article.CheckOut();
            Assert.That(article.CheckIn(), Is.EqualTo("Item has been checked in"));
        }

        [Test]
        public void ShouldDeclineCheckInIfNotOnLoan()
        {
            Assert.That(article.CheckIn(), Is.EqualTo("Item is not currently on loan"));
        }
    }
}