using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryTest
    {
        [Test]
        public void ShouldAddItemToLibraryCollection()
        {
            Library library = new Library();
            LibraryItem item = new Article("Sample Article", new Author("John Doe", "john@example.com", "www.example.com"));

            library.AddToStock(item);

            Assert.IsTrue(library.ContainsItem(item));
        }

        [Test]
        public void ShouldRemoveItemFromLibraryCollection()
        {
            Library library = new Library();
            LibraryItem item = new Article("Sample Article", new Author("John Doe", "john@example.com", "www.example.com"));

            library.AddToStock(item);
            library.RemoveItem(item);

            Assert.IsFalse(library.ContainsItem(item));
        }

        [Test]
        public void ShouldCheckInItem()
        {
            Library library = new Library();
            LibraryItem item = new Article("Sample Article", new Author("John Doe", "john@example.com", "www.example.com"));

            library.AddToStock(item);
            item.CheckOut();

            string result = library.CheckInItem(item);

            Assert.AreEqual("Item has been checked in!", result);
        }

        [Test]
        public void ShouldCheckOutItem()
        {
            Library library = new Library();
            LibraryItem item = new Article("Sample Article", new Author("John Doe", "john@example.com", "www.example.com"));

            library.AddToStock(item);

            string result = library.CheckOutItem(item);

            Assert.AreEqual("Item has been checked out!", result);
        }
    }
}
