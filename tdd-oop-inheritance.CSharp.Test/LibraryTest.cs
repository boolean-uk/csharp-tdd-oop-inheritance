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
            Author author = new Author("Andrew Jegman", "andrew@nocontact.com", "jegman.com");
            Author dAdams = new Author("Douglas Adams", "idont@know.com", "https://www.bbc.co.uk/programmes/articles/1g84m0sXpnNCv84GpN2PLZG/the-game-30th-anniversary-edition");
            library.addToStock(new Article("JUnit Rocks", author));
            library.addToStock(new Book("Hitchiker's guide to the galaxy", dAdams));
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

        [Test]
        public void shouldNotHaveAuthor()
        {
            Assert.That(library.getAuthor("New York Times"), Is.EqualTo("item does not have a single author"));
        }

        [Test]
        [TestCase("Hitchiker's guide to the galaxy", "Douglas Adams")]
        [TestCase("JUnit Rocks", "Andrew Jegman")]
        public void shouldHaveAuthor(string item, string author)
        {
            Assert.That(library.getAuthor(item), Is.EqualTo(author));
        }
    }
}
