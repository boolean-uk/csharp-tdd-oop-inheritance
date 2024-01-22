using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;


namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        [Test]
        public void AddLibraryIem()
        {
            Library library = new Library();
            LibraryItem libraryItem = new LibraryItem("Harry Potter");
            library.addToStock(libraryItem);

            Assert.AreEqual("Harry Potter", library.libraryItems[0].title);
            
        }

        [Test]
        public void AddBook()
        {
            Library library = new Library();
            Author author = new Author("JK", "JK@mail", "jk.com");
            Book book = new Book("Harry Potter", author);
            library.addToStock(book);

            Assert.AreEqual("Harry Potter", library.libraryItems[0].title);

        }

        [Test]
        public void AddArticle()
        {
            Library library = new Library();
            Author author = new Author("John Smith", "smith@mail.com", "Smith.com");
            Article article = new Article("Benefits of C#", author);
            library.addToStock(article);

            Assert.AreEqual("Benefits of C#", library.libraryItems[0].title);

        }

        [Test]
        public void AddNewspaper()
        {
            Library library = new Library();
            Newspaper newspaper = new Newspaper("Benefits of C#");
            library.addToStock(newspaper);

            Assert.AreEqual("Benefits of C#", library.libraryItems[0].title);

        }

        [Test]

        public void CheckForAuthor()
        {
            Library library = new Library();
            Author author = new Author("John Smith", "smith@mail.com", "Smith.com");
            Article article = new Article("Benefits of C#", author);
            library.addToStock(article);
            string item = ("Benefits of C# John Smith smith@mail.com Smith.com");
            string s = library.libraryItems[0].ToString();
            Assert.That(item, Is.EqualTo(s));
        }

        [Test]

        public void canNotCheckInLibraryIem()
        {
            // Arrange
            Library library = new Library();
            Author author = new Author("John Smith", "smith@mail.com", "Smith.com");
            Book book = new Book("Harry Potter", author);

            // Act
            string result = library.checkInLibraryItem(book.title);

            // Assert
            Assert.AreEqual("item is not part of the library's collection", result);

        }

        [Test]
        public void CheckInLibraryItem()
        {
            // Arrange
            Library library = new Library();
            Author author = new Author("John Smith", "smith@mail.com", "Smith.com");
            Book book = new Book("Harry Potter", author);

            // Act
            library.addToStock(book);
            library.checkOutLibraryIem(book.title);
            string result = library.checkInLibraryItem(book.title);

            // Assert
            Assert.AreEqual("item has been checked in", result);

        }

        [Test]
        public void canNotCheckOutLibraryIem()
        {
            // Arrange
            Library library = new Library();
            Author author = new Author("John Smith", "smith@mail.com", "Smith.com");
            Book book = new Book("Harry Potter", author);

            // Act
            string result = library.checkOutLibraryIem(book.title);

            // Assert
            Assert.AreEqual("item is not part of the library's collection", result);

        }

        [Test]
        public void CheckOutLibraryIem()
        {
            // Arrange
            Library library = new Library();
            Author author = new Author("John Smith", "smith@mail.com", "Smith.com");
            Book book = new Book("Harry Potter", author);

            // Act
            library.addToStock(book);
            string result = library.checkOutLibraryIem(book.title);

            // Assert
            Assert.AreEqual("item has been checked out", result);

        }
    }
}
