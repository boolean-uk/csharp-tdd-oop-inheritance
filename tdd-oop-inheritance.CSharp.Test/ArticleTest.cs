using NUnit.Framework;
using LibraryItems;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        private Author author;

        [SetUp]
        public void Setup()
        {
            // Initialize an Author object before each test
            author = new Author { Name = "Author Name", ContactInformation = "Contact Info", Website = "http://authorwebsite.com" };
        }

        [Test]
        public void shouldCheckOutIfAvailable()
            {
                Article article = new Article("JUnit Rocks", author);
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {   
                Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                Article article = new Article("JUnit Rocks", author);

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }
    }
}