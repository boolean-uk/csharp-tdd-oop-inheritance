using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        Article article;
        Author author;

        [SetUp]
        public void SetUp() {
            author = new Author("Adrian", "adrian@gmail.com", "www.adrian.com");
            article = new Article("JUnit Rocks", author);

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

        [Test]
        public void ShouldHaveAuthor()
        {
            Assert.That(article.Author.Name, !Is.Empty);
            Assert.That(article.Author.ContactInfo, !Is.Empty);
            Assert.That(article.Author.Website, !Is.Empty);
        }
    }
}