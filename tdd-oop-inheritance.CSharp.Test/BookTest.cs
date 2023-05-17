using NUnit.Framework;
using LibraryItems;

namespace tdd.oop.inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void ShouldCheckOutIfAvailable()
        {
            Book book = new("JUnit Rocks");
            Assert.AreEqual("item has been checked out", book.CheckOut());
        }

        [Test]
        public void ShouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new("JUnit Rocks");
            book.CheckOut();

            Assert.AreEqual("item is currently on loan", book.CheckOut());
        }

        [Test]
        public void ShouldCheckInIfOnLoan()
        {
            Book book = new("JUnit Rocks");
            book.CheckOut();

            Assert.AreEqual("item has been checked in", book.CheckIn());
        }

        [Test]
        public void ShouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new("JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", book.CheckIn());
        }
    }
}