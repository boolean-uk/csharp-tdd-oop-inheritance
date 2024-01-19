using LibraryItems;
using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
#pragma warning disable CS8618
        Book book;
        [SetUp]
        public void SetUp()
        {
            Author author = new("Test", "test", "test.com");
            book = new("NUnit Rocks!", author);
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