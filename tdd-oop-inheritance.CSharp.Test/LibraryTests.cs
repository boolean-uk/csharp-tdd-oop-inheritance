using Administration;
using Items;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryTests
    {
        [Test]
        public void TestAddNewStock()
        {
            Library library = new Library();
            library.addToStock(new Newspaper("C# Times"));
            library.addToStock(new Book("Everything and more in C#"));
            library.addToStock(new Article("C# and more"));
            int result = 3;
            Assert.AreEqual(result, library.Items.Count);
        }
        [Test]
        public void TestCheckInItem()
        {
            Library library = new Library();
            library.addToStock(new Newspaper("C# Times"));
            library.addToStock(new Book("Everything and more in C#"));
            library.addToStock(new Article("C# and more"));
            library.checkOutItem("Everything and more in C#");
            Assert.AreEqual(library.checkInItem("C# Times"), "newspapers are not available for loan");
            Assert.AreEqual(library.checkInItem("Everything and more in C#"), "item has been checked in");
            Assert.AreEqual(library.checkInItem("More C#"), "item is not part of the library's collection");
        }
        [Test]
        public void TestCheckOutItem()
        {
            Library library = new Library();
            library.addToStock(new Newspaper("C# Times"));
            library.addToStock(new Book("Everything and more in C#"));
            library.addToStock(new Article("C# and more"));
            Assert.AreEqual(library.checkOutItem("C# Times"), "newspapers are not available for loan");           
            Assert.AreEqual(library.checkOutItem("Everything and more in C#"), "item has been checked out");

        }
    }
}
