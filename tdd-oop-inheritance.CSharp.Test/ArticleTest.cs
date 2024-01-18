using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        private Article article = null;
        [SetUp]
        public void SetUp() {
            List<Author> authors = [new Author("test", "test", "test")];
            article = new Article("JUnit Rocks", authors);
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