using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryTest
    {
        private Author _author;

        [SetUp]
        public void SetUp()
        {
            _author = new Author("TestName", "SomeContactInfo", "SomeURl");
        }

        [Test]
        public void TestAddToStock()
        {
            //setup
            Library lib = new();
            LibraryItem item = new Book("some book", _author);

            //execute
            lib.AddToStock(item);

            //verify
            Assert.That(lib.libraryItems.Count, Is.EqualTo(1));
        }

        [Test]
        public void TestCheckOutLibraryItem()
        {
            //setup
            Library lib = new();
            LibraryItem item = new Book("some book", _author);
            lib.AddToStock(item);

            //execute
            string res = lib.CheckOutLibraryItem("some book");
            string shouldBeLoanedAlready = lib.CheckOutLibraryItem("some book");
            string shouldNot = lib.CheckOutLibraryItem("adgoiwjg");

            //assert
            Assert.That(res, Is.EqualTo("item has been checked out"));
            Assert.That(shouldBeLoanedAlready, Is.EqualTo("item is currently on loan"));
            Assert.That(shouldNot, Is.EqualTo("item is not part of the library's collection"));
        }

        [Test]
        public void TestCheckInLibraryItem()
        {
            //setup
            Library lib = new();
            LibraryItem item = new Book("some book", _author);
            lib.AddToStock(item);
            lib.CheckOutLibraryItem("some book");

            //execute
            string res = lib.CheckInLibraryItem("some book");
            string shouldBeCheckedInAlready = lib.CheckInLibraryItem("some book");
            string shouldNot = lib.CheckInLibraryItem("adgoiwjg");

            //assert
            Assert.That(res, Is.EqualTo("item has been checked in"));
            Assert.That(shouldBeCheckedInAlready, Is.EqualTo("item is not currently on loan"));
            Assert.That(shouldNot, Is.EqualTo("item is not part of the library's collection"));
        }
    }
}
