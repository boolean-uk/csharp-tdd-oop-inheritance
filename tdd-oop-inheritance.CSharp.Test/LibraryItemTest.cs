using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryItemTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            LibraryItem item = new LibraryItem("JUnit Rocks");
            Assert.AreEqual("item has been checked out", item.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            LibraryItem item = new LibraryItem("JUnit Rocks");
            item.checkOut();

            Assert.AreEqual("item is currently on loan", item.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            LibraryItem item = new LibraryItem("JUnit Rocks");
            item.checkOut();

            Assert.AreEqual("item has been checked in", item.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            LibraryItem item = new LibraryItem("JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", item.checkIn());
        }
    }
}

