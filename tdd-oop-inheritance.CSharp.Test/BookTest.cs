using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        private Book book = null;
        [SetUp]
        public void SetUp() {
            List<Author> authors = [new Author("test", "test", "test")];
            book = new Book("JUnit Rocks", authors);
        }

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}