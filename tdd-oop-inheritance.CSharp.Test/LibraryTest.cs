using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    internal class LibraryTest
    {

        Library lib;
        Book book;
        Article article;
        Newspaper newspaper;

        [SetUp]
        public void SetUp ()
        {
            lib = new Library();
            book = new Book("JUnit Rocks");
            article = new Article("JUnit doesn't rock");
            newspaper = new Newspaper("JUnit..");

            lib.addToStock(book);
            lib.addToStock(article);
            lib.addToStock(newspaper);
        }

        [Test]
        public void ShouldCheckOut()
        {
            string response = lib.checkOutItem("JUnit doesn't rock");
            Assert.That(article.isOnLoan(), Is.True);
            Assert.That(response, Is.EqualTo("item has been checked out"));
        }

        [Test]
        public void ShouldNotCheckOut()
        {
            lib.checkOutItem("JUnit Rocks");
            string response = lib.checkOutItem("JUnit Rocks");
            Assert.That(book.isOnLoan(), Is.True);
            Assert.That(response, Is.EqualTo("item is currently on loan"));
        }

        [Test]
        public void ShouldCheckIn()
        {
            lib.checkOutItem("JUnit doesn't rock");
            string response = lib.checkInItem("JUnit doesn't rock");
            Assert.That(article.isOnLoan(), Is.False);
            Assert.That(response, Is.EqualTo("item has been checked in"));
        }

        [Test]
        public void ShouldNotCheckIn()
        {
            string response = lib.checkInItem("JUnit doesn't rock");
            Assert.That(article.isOnLoan(), Is.False);
            Assert.That(response, Is.EqualTo("item is not currently on loan"));
        }

        [Test]
        public void NewsletterShouldntCheckIn()
        {
            lib.checkOutItem("JUnit..");
            string response = lib.checkInItem("JUnit..");
            Assert.That(newspaper.isOnLoan(), Is.False);
            Assert.That(response, Is.EqualTo("newspapers are not available for loan"));
        }

        [Test]
        public void NewsletterShouldntCheckOut()
        {
            string response = lib.checkOutItem("JUnit..");
            Assert.That(article.isOnLoan(), Is.False);
            Assert.That(response, Is.EqualTo("newspapers are not available for loan"));
        }
    }
}
