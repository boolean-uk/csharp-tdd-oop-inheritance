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

        [Test]
        public void GetAuthorName_Article()
        {
            Author author = new Author("Scrooge McDuck", "The Money Bin", "en.wikipedia.org/wiki/Scrooge_McDuck");
            Article article = new Article("Taxes are too damn high", author);

            string expectedResult = article.getAuthorName();
            string actualResult = "Scrooge McDuck";
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}