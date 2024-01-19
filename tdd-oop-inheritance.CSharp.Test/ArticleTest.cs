using LibraryItems;
using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
#pragma warning disable CS8618
        Article article;
        [SetUp]
        public void SetUp()
        {
            Author author = new("Test", "test", "test.com");
            article = new Article("NUnit Rocks!", author);
        }
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Assert.AreEqual("item has been checked out", article.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            article.checkOut();

            Assert.AreEqual("item is currently on loan", article.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            article.checkOut();

            Assert.AreEqual("item has been checked in", article.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {

            Assert.AreEqual("item is not currently on loan", article.checkIn());
        }
    }
}