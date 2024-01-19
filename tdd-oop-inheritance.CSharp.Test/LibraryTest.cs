using LibraryItems;
using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryTest
    {
#pragma warning disable CS8618
        private Library _library;
        [SetUp]
        public void SetUp()
        {
            _library = new Library();
        }

        private static List<Author> _authors = [
            new Author("J. K. Rowling", "9999999", "SomeWebsite.com"),
            new Author("Tolkien", "1251251", "AnotherSite.com")];

        [DatapointSource]
        public ILibraryItem[] LibraryItems = [
            new Article("How to create test in .NET 101", _authors[0]),
            new Book("The Lord of the Rings", _authors[1]),
            new Newspaper("The Telegraph")
        ];

        [Theory]
        public void AddToStockTest(ILibraryItem item)
        {
            Assert.DoesNotThrow(() => _library.addToStock(item));
        }

        [Test]
        public void LibraryCanCheckIn()
        {
            _library.addToStock(new Article("Some article", _authors[0]));
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
