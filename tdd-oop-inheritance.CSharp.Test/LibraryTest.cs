using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class LibraryTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {   
                Article article = new Article("JUnit Rocks");
            Library library = new Library();
            library.addToStock(article);
           Assert.That(article.isOnLoan() == false, Is.True);
           Assert.AreEqual("item has been checked out", library.checkOut(article));
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
            Library lib = new Library();
            Article article = new Article("JUnit Rocks");
            lib.addToStock(article);
            lib.checkOut(article);

            Assert.AreEqual("item is currently on loan", lib.checkOut(article));
        }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
            Library lib = new Library();
            Book book = new Book("C#Unit 3 Rocks");
            lib.addToStock(book);
            lib.checkOut(book); 
                
                Assert.AreEqual("item has been checked in", lib.checkIn(book));
            }

        [Test]
        public void shouldDeclineifnotInList()
            {
            Author author = new Author(name: "Jane Johnson", adress: "jane@johnson.com", website: "");
                Article article = new Article("JUnit Rocks", author);
                Library lib = new Library();

                Assert.AreEqual("item is not part of the library's collection", lib.checkIn(article));
            }
        [Test]
        public void checkifAuthorIsSet()
        {
            Author author = new Author(name: "Jane Johnson", adress: "jane@johnson.com", website: "");
            Article article = new Article("JUnit Rocks", author);  

            Assert.AreEqual("Jane Johnson",article.Author.Name );
        }
        [Test]
        public void checkifAuthorIsSetEmpty()
        {
            Book book = new Book("JUnit Rocks");
            Library lib = new Library();
            lib.addToStock(book);

            Assert.IsTrue(book._author.Name == string.Empty);
        }

    }
}