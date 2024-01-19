using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    internal class LibraryTest
    {
        private Library library;
        [SetUp] 
        public void SetUp() 
        {
            library = new Library();
            library.addToStock(new Article("JUnit Rocks"));
            library.addToStock(new Book("Hitchiker's guide to the galaxy"));
            library.addToStock(new Newspaper("New York Times"));
        }

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Assert.That(library.checkOut("JUnit Rocks"), Is.EqualTo("item has been checked out"));
        }


        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            library.checkOut("JUnit Rocks");

            Assert.That(library.checkOut("JUnit Rocks"), Is.EqualTo("item is currently on loan"));
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            library.checkOut("JUnit Rocks");
            Assert.That(library.checkIn("JUnit Rocks"), Is.EqualTo("item has been checked in"));
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
        }

        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            Assert.That(library.checkIn("New York Times"), Is.EqualTo("newspapers are not available for loan"));
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            Assert.That(library.checkOut("New York Times"), Is.EqualTo("newspapers are not available for loan"));
        }
    }
}
