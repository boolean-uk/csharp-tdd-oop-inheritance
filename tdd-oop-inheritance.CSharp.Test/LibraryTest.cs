using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class LibraryTest
    {
        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            Library library = new Library();
            Item newspaper = new Newspaper("See sharp today!");
            library.addToStock(newspaper);

            Assert.AreEqual("newspapers are not available for loan", library.checkInItem("See sharp today!"));
        }

        [Test]
        public void ShouldCheckInItem()
        {
            Author author = new Author("Henrik Ibsen", "He is dead", "HeIsDead.com");
            Library library = new Library();
            Item book = new Book("The qualities of seeing sharp", author);
            library.addToStock(book);
            library.checkOutItem("The qualities of seeing sharp");

            Assert.AreEqual("item has been checked in", library.checkInItem("The qualities of seeing sharp"));
        }

        [Test]
        public void checkinShouldDeclineIfNotPartOfLibaryCollection()
        {
            Author author = new Author("Henrik Ibsen", "He is dead", "HeIsDead.com");
            Library library = new Library();
            Item book = new Book("The qualities of seeing sharp", author);
            library.checkOutItem("The qualities of seeing sharp");

            Assert.AreEqual("item is not part of the library's collection", library.checkInItem("The qualities of seeing sharp"));
        }

        [Test]
        public void ShouldCheckOutItem()
        {
            Author author = new Author("Henrik Ibsen", "He is dead", "HeIsDead.com");
            Library library = new Library();
            Item article = new Article("See sharp is better than java coffee", author);
            library.addToStock(article);

            Assert.AreEqual("item has been checked out", library.checkOutItem("See sharp is better than java coffee"));
        }

        [Test]
        public void checkoutShouldDeclineIfNotPartOfLibaryCollection()
        {
            Author author = new Author("Henrik Ibsen", "He is dead", "HeIsDead.com");
            Library library = new Library();
            Item book = new Book("The qualities of seeing sharp", author);
            library.checkInItem("The qualities of seeing sharp");

            Assert.AreEqual("item is not part of the library's collection", library.checkInItem("The qualities of seeing sharp"));
        }
    }
}