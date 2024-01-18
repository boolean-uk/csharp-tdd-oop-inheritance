using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class ItemTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Item item = new Item("JUnit Rocks");
            Assert.AreEqual("item has been checked out", item.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Item item = new Item("JUnit Rocks");
            item.checkOut();

            Assert.AreEqual("item is currently on loan", item.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Item item = new Item("JUnit Rocks");
            item.checkOut();

            Assert.AreEqual("item has been checked in",item.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Item item = new Item("JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", item.checkIn());
        }
    }
}