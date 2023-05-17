using NUnit.Framework;
using LibraryItems;

namespace tdd.oop.inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void ShouldCheckOutIfAvailable()
        {
            Article article = new("JUnit Rocks");
            Assert.AreEqual("item has been checked out", article.CheckOut());
        }

        [Test]
        public void ShouldDeclineIfNotAvailableToCheckout()
        {
            Article article = new("JUnit Rocks");
            article.CheckOut();

            Assert.AreEqual("item is currently on loan", article.CheckOut());
        }

        [Test]
        public void ShouldCheckInIfOnLoan()
        {
            Article article = new("JUnit Rocks");
            article.CheckOut();

            Assert.AreEqual("item has been checked in", article.CheckIn());
        }

        [Test]
        public void ShouldDeclineCheckInIfNotOnLoan()
        {
            Article article = new("JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", article.CheckIn());
        }
    }
}