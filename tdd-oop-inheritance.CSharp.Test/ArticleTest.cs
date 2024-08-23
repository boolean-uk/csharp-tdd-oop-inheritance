using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        Author author;

        [SetUp]
        public void SetUp()
        {
            this.author = new Author("Bob Bagel", "+4712345678", "http://bobsemail.com");
        }

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            LibraryItem article = new Article(author, "JUnit Rocks");
            Assert.AreEqual("item has been checked out", article.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            LibraryItem article = new Article(author, "JUnit Rocks");
            article.checkOut();

            Assert.AreEqual("item is currently on loan", article.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            LibraryItem article = new Article(author, "JUnit Rocks");
            article.checkOut();

            Assert.AreEqual("item has been checked in", article.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            LibraryItem article = new Article(author, "JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", article.checkIn());
        }
}
}