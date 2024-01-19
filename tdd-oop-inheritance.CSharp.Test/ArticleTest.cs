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
        public void AuthorArticleTest()
        {
            List<Literature> testList = new List<Literature>();
            Book article1 = new Book("A Song of Ice and Fire");
            article1.SetAuthor("George R. R. Martin", "12345678", "neverfinishingthatbook.com");
            Assert.That(article1.GetAuthor()._name.Equals("George R. R. Martin"));
            Assert.That(article1.GetAuthor()._number.Equals("12345678"));
            Assert.That(article1.GetAuthor()._website.Equals("neverfinishingthatbook.com"));
        }
    }
}