using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    class LibraryItemTest
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

        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkIn());
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkOut());
        }
    }
}
