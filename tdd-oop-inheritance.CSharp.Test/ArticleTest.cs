using NUnit.Framework;
using LibraryItems;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {
                Article article = new Article("JUnit Rocks");
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                Article article = new Article("JUnit Rocks");
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                Article article = new Article("JUnit Rocks");
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                Article article = new Article("JUnit Rocks");

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }
    }
}