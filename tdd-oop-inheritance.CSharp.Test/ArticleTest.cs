using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {

        private Author author;
        private Article article;

        [SetUp]
        public void SetUp() {
            author = new Author("Test Testsson", "test.testsson@email.com", "www.testtesstsson.com");
            string title = "JUnit Rocks";
            article = new Article(title, author);
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
        public void shouldGetAuthorInformation()
        {
            Assert.AreEqual("Title: JUnit Rocks, On Loan: False\nAuthor: Test Testsson\nContact information: test.testsson@email.com\nWebsite: www.testtesstsson.com", article.getInformation());
        }

    }
}