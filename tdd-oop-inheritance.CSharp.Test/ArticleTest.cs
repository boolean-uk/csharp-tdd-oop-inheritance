using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {
                Article article = new Article("JUnit Rocks");
                Assert.AreEqual("item has been checked out", article.CheckOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                Article article = new Article("JUnit Rocks");
                article.CheckOut();

                Assert.AreEqual("item is currently on loan", article.CheckOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                Article article = new Article("JUnit Rocks");
                article.CheckOut();

                Assert.AreEqual("item has been checked in", article.CheckIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                Article article = new Article("JUnit Rocks");

                Assert.AreEqual("item is not currently on loan", article.CheckIn());
            }
    }
}