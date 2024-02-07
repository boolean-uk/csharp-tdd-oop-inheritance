using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        Author author;

        [SetUp]
        public void Setup()
        {
            Author author = new Author("Author Name", "Author email");
        }

        [Test]
        public void shouldCheckOutIfAvailable()
            {
                Article article = new Article(author, "JUnit Rocks");
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                Article article = new Article(author, "JUnit Rocks");
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                Article article = new Article(author, "JUnit Rocks");
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                Article article = new Article(author, "JUnit Rocks");

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }
    }
}