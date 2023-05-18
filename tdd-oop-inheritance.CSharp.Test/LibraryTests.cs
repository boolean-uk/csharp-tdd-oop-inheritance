using Administration;
using Items;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Author;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryTests
    {
        [Test]
        public void TestAddNewStock()
        {
            IAuthor author1 = new Author() { name="Dave" };
            IAuthor author2 = new Author() { name="Nigel" };
            Library library = new Library();
            library.addToStock(new Newspaper("C# Times"));
            library.addToStock(new Book("Everything and more in C#", author1));
            library.addToStock(new Article("C# and more", author2));
            int result = 3;
            Assert.AreEqual(result, library.Items.Count);
        }
        [Test]
        public void TestCheckInItem()
        {
            Author author1 = new Author() { name="Dave" };
            IAuthor author2 = new Author() { name="Nigel" };
            Library library = new Library();
            library.addToStock(new Newspaper("C# Times"));
            library.addToStock(new Book("Everything and more in C#", author2));
            library.addToStock(new Article("C# and more", author1));
            library.checkOutItem("Everything and more in C#");
            Assert.AreEqual(library.checkInItem("C# Times"), "newspapers are not available for loan");
            Assert.AreEqual(library.checkInItem("Everything and more in C#"), "item has been checked in");
            Assert.AreEqual(library.checkInItem("More C#"), "item is not part of the library's collection");
        }
        [Test]
        public void TestCheckOutItem()
        {
            Author author1 = new Author() { name="Dave" };
            IAuthor author2 = new Author() { name="Nigel" };
            Library library = new Library();
            library.addToStock(new Newspaper("C# Times"));
            library.addToStock(new Book("Everything and more in C#", author2));
            library.addToStock(new Article("C# and more", author1));
            Assert.AreEqual(library.checkOutItem("C# Times"), "newspapers are not available for loan");           
            Assert.AreEqual(library.checkOutItem("Everything and more in C#"), "item has been checked out");

        }
    }
}
