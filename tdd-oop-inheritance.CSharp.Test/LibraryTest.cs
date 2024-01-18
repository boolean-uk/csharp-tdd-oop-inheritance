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
        public void checkInBook(string title)
        {
            Library library = new Library();
            library.addToStock(new Book(title, "Roger", "075123123", "website.com"));
            Assert.That(library.CheckInItem(title), Is.EqualTo("item is not currently on loan"));
            library.CheckOutItem(title);
            Assert.That(library.CheckInItem(title), Is.EqualTo("item has been checked in"));

        }
        //Article
        [TestCase("Article")]
        public void ArticleCheckIn(string title)
        {
            var library = new Library();
            library.addToStock(new Article(title, "Bengt", "12395231", "website.bengt.com"));
            Assert.That(library.CheckInItem(title), Is.EqualTo("item is not currently on loan"));
            library.CheckOutItem(title);
            Assert.That(library.CheckInItem(title), Is.EqualTo("item has been checked in"));
        }
        //Newspaper
        [TestCase("Newspaper")]
        public void NewspaperCheckIn(string title)
        {
            Library library = new Library();
            library.addToStock(new Newspaper(title));
            Assert.That(library.CheckInItem(title), Is.EqualTo("newspapers are not available for loan"));
        }

        //-------------------------------------------------------
        //CHECKOUT
        //Book
        [TestCase("Book")]
        public void BookCheckOut(string title)
        {
            Library library = new Library();
            library.addToStock(new Book(title, "Roger", "075123123", "website.com"));
            Assert.That(library.CheckOutItem(title), Is.EqualTo("item has been checked out"));
            Assert.That(library.CheckOutItem(title), Is.EqualTo("item is currently on loan"));
        }

        //Article
        [TestCase("Article")]
        public void ArticleCheckOut(string title)
        {
            var library = new Library();
            library.addToStock(new Article(title, "Bengt", "12395231", "website.bengt.com"));
            Assert.That(library.CheckOutItem(title), Is.EqualTo("item has been checked out"));
            Assert.That(library.CheckOutItem(title), Is.EqualTo("item is currently on loan"));
        }

        //Newspaper
        [TestCase("Newspaper")]
        public void NewspaperCheckOut(string title)
        {
            Library library = new Library();
            library.addToStock(new Newspaper(title));
            Assert.That(library.CheckOutItem(title), Is.EqualTo("newspapers are not available for loan"));
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
