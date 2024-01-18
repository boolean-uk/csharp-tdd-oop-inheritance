using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    internal class LibraryTest
    {

        //CHECKIN
        //Book
        [TestCase("Book")]
        public void checkInBook(string name)
        {
            Library library = new Library();
            library.addToStock(new Book(name));
            Assert.That(library.CheckInItem(name), Is.EqualTo("item is not currently on loan"));
            library.CheckOutItem(name);
            Assert.That(library.CheckInItem(name), Is.EqualTo("item has been checked in"));

        }
        //Article
        [TestCase("Article")]
        public void ArticleCheckIn(string name)
        {
            var library = new Library();
            library.addToStock(new Article(name));
            Assert.That(library.CheckInItem(name), Is.EqualTo("item is not currently on loan"));
            library.CheckOutItem(name);
            Assert.That(library.CheckInItem(name), Is.EqualTo("item has been checked in"));
        }
        //Newspaper
        [TestCase("Newspaper")]
        public void NewspaperCheckIn(string name)
        {
            Library library = new Library();
            library.addToStock(new Newspaper(name));
            Assert.That(library.CheckInItem(name), Is.EqualTo("newspapers are not available for loan"));
        }

        //-------------------------------------------------------
        //CHECKOUT
        //Book
        [TestCase("Book")]
        public void BookCheckOut(string name)
        {
            Library library = new Library();
            library.addToStock(new Book(name));
            Assert.That(library.CheckOutItem(name), Is.EqualTo("item has been checked out"));
            Assert.That(library.CheckOutItem(name), Is.EqualTo("item is currently on loan"));
        }

        //Article
        [TestCase("Article")]
        public void ArticleCheckOut(string name)
        {
            var library = new Library();
            library.addToStock(new Article(name));
            Assert.That(library.CheckOutItem(name), Is.EqualTo("item has been checked out"));
            Assert.That(library.CheckOutItem(name), Is.EqualTo("item is currently on loan"));
        }

        //Newspaper
        [TestCase("Newspaper")]
        public void NewspaperCheckOut(string name)
        {
            Library library = new Library();
            library.addToStock(new Newspaper(name));
            Assert.That(library.CheckOutItem(name), Is.EqualTo("newspapers are not available for loan"));
        }

        //General------------------------------------------------------
        [Test]
        public void FailLibraryCheckout()
        {
            var library = new Library();
            Assert.That(library.CheckOutItem("notInStock"), Is.EqualTo("item is not part of the library's collection"));
        }
    }
}
