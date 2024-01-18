using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LiteratureTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Literature literature = new Literature("JUnit Rocks");
            Assert.AreEqual("item has been checked out", literature.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Literature literature = new Literature("JUnit Rocks");
            literature.checkOut();

            Assert.AreEqual("item is currently on loan", literature.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Literature literature = new Literature("JUnit Rocks");
            literature.checkOut();

            Assert.AreEqual("item has been checked in", literature.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Literature literature = new Literature("JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", literature.checkIn());
        }
    }
}