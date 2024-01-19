using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        Library library = new Library();
        [SetUp]
        public void SetUp()
        {
            Book checkedOutbook = new Book("checkOut");
            checkedOutbook.checkOut();
            library.paperThings.Add(checkedOutbook);
            library.paperThings.Add(new Book("testBook"));
            library.paperThings.Add(new Article("testArticle"));
            library.paperThings.Add(new Newspaper("testPaper"));

        }
        [Test]
        public void shouldAddToStock()
        {
            Book book = new Book("JUnit Rocks");
            library.addToStock(book);
            Assert.IsTrue(library.paperThings.Contains(book));
        }
        [Test]
        public void shouldCheckIn()
        {
            Assert.AreEqual("item has been checked in", library.checkInPaperThing("checkOut"));
        }
        [Test]
        public void shouldCheckOut()
        {
            Assert.AreEqual("item has been checked out", library.checkOutPaperThing("testBook"));
        }
        [Test]
        public void shouldNotBeInLibrary()
        {
            Assert.AreEqual("item is not part of the library's collection", library.checkInPaperThing("wrongBook"));
        }
        [Test]
        public void shouldNotBeCheckingOutNewspaper()
        {
            Assert.AreEqual("newspapers are not available for loan", library.checkOutPaperThing("testPaper"));
        }

    }
}