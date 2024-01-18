using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        Library _library;
        Author author;
        public LibraryTest()
        {
            _library = new Library();
            author = new Author("Rick Riordan");
        }

        [Test] 
        public void checkInTest()
        {
            Book book = new Book("The lightning thief", author);
            _library.addToStock(book);
            Assert.That(_library.checkInItem("The lightning thief"), Is.EqualTo("item is not currently on loan"));
        }

        [Test]
        public void checkOutTest()
        {
            Book book = new Book("Sea of monsters", author);
            _library.addToStock(book);
            Assert.That(_library.checkOutItem("Sea of monsters"), Is.EqualTo("item has been checked out"));
        }

        [Test]
        public void checkIn2Test()
        {
            Book book = new Book("The titan curse", author);
            _library.addToStock(book);
            _library.checkOutItem("The titan curse");
            Assert.That(_library.checkInItem("The titan curse"), Is.EqualTo("item has been checked in"));
        }
        [Test]
        public void checkOut2Test()
        {
            Book book = new Book("Battle of the Labyrinth", author);
            _library.addToStock(book);
            _library.checkOutItem("Battle of the Labyrinth");
            Assert.That(_library.checkOutItem("Battle of the Labyrinth"), Is.EqualTo("item is currently on loan"));
        }

        [Test]
        public void nonExistingBookTest()
        {
            Assert.That(_library.checkOutItem("The last Olympian"), Is.EqualTo("item is not part of the library's collection"));
            Assert.That(_library.checkInItem("The last Olympian"), Is.EqualTo("item is not part of the library's collection"));
        }

    }
}