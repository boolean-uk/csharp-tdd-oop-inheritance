using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Book book = new Book("JUnit Rocks");
            Assert.AreEqual("item has been checked out", book.CheckOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new Book("JUnit Rocks");
            book.CheckOut();

            Assert.AreEqual("item is currently on loan", book.CheckOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Book book = new Book("JUnit Rocks");
            book.CheckOut();

            Assert.AreEqual("item has been checked in", book.CheckIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new Book("JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", book.CheckIn());
        }
    }
}