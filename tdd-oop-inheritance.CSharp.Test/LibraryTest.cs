using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryTest
    {
        private Library _library;
        [SetUp]
        public void SetUp() 
        {
            _library = new Library();
        }

        [DatapointSource]
        public ILibraryItem[] LibraryItems = [
            new Article("How to create test in .NET 101"), new Book("The Lord of the Rings"), new Newspaper("The Telegraph")
        ];

        [Theory]
        public void AddToStockTest(ILibraryItem item)
        {
            Assert.DoesNotThrow(() => _library.addToStock(item));
        }

        [Test]
        public void LibraryCanCheckIn()
        {
            _library.addToStock(new Article("Some article"));
            _library.checkIn("Some article");
            Assert.That(_library.checkIn("Some article"), Is.EqualTo("item is not currently on loan"));
        }

        [Test]
        public void LibraryCanCheckOut()
        {
            _library.addToStock(new Newspaper("The Journal"));
            _library.checkOut("The Journal");
            Assert.That(_library.checkOut("The Journal"), Is.EqualTo("newspapers are not available for loan"));
        }
    }
}
