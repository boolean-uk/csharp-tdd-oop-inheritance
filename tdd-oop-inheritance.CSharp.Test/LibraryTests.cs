using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;


namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryTests
    {
        private Library library;
        [SetUp]
        public void Setup()
        {
            library = new Library();
        }

        [Test]
        public void AddToStockAreItemsCorrectlyAdded()
        {
            var book = new Book("Harry Potter");
            library.addToStock(book);
            Assert.IsTrue(library.Items.Contains(book));
        }
        [Test]
        public void ItemNotInCollectionShouldReturnErrorMessage()
        {
            var response = library.checkOutItem("Nonexistent Book");
            Assert.AreEqual("item is not part of the library's collection", response);
        }
    }
}
