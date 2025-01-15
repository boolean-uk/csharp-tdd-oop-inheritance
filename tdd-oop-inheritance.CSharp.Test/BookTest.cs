using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author author = new Author("Axel", "95901753", "www.com");
            ItemClass item = new Book("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", item.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author author = new Author("Axel", "95901753", "www.com");
            ItemClass item = new Book("JUnit Rocks", author);
            item.checkOut();

            Assert.AreEqual("item is currently on loan", item.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author author = new Author("Axel", "95901753", "www.com");
            ItemClass article = new Book("JUnit Rocks", author);
            article.checkOut();

            Assert.AreEqual("item has been checked in", article.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new Author("Axel", "95901753", "www.com");
            ItemClass article = new Book("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", article.checkIn());
        }

        [Test]
        public void getAuthorName()
        {
            Author author = new Author("Axel", "95901753", "www.com");
            ItemClass article = new Book("JUnit Rocks", author);
            string name = author.name;
            Assert.That(name == article.returnAuthor().name);
        }
    }
}