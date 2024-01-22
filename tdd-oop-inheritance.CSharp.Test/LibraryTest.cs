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
    internal class LibraryTest
    {
        private Library library;

        [SetUp]
        public void SetUp()
        {
            this.library = new Library();
            library.AddToStock(new Book("The Tale of Two Cities"));
            library.AddToStock(new Book("Moby Dick"));
            library.AddToStock(new Newspaper("The Daily Monologue"));
            library.AddToStock(new Article("Why C# is Better Than Java"));
        }

        [Test]
        public void CheckInTest()
        {
            string inStockBookMessage = library.CheckInItem("Moby Dick");
            string notInStockBookMessage = library.CheckInItem("The Necronomicon");
            string inStockArticleMessage = library.CheckInItem("Why C# is Better Than Java");
            string inStockNewspaperMessage = library.CheckInItem("The Daily Monologue");
            Assert.That(inStockBookMessage == "item is not currently on loan");
            Assert.That(notInStockBookMessage == "item is not part of the library's collection");
            Assert.That(inStockArticleMessage == "item is not currently on loan");
            Assert.That(inStockNewspaperMessage == "item is not loanable");
        }

        [Test]
        public void CheckOutTest()
        {
            string inStockBookMessage = library.CheckOutItem("Moby Dick");
            string notInStockBookMessage = library.CheckOutItem("The Necronomicon");
            string inStockArticleMessage = library.CheckOutItem("Why C# is Better Than Java");
            string inStockNewspaperMessage = library.CheckOutItem("The Daily Monologue");
            Assert.That(inStockBookMessage == "item has been checked out");
            Assert.That(notInStockBookMessage == "item is not part of the library's collection");
            Assert.That(inStockArticleMessage == "item has been checked out");
            Assert.That(inStockNewspaperMessage == "item is not loanable");
        }
    }
}
