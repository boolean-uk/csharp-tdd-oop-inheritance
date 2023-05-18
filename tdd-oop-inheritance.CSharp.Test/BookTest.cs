using Interface.oop.inheritance.CSharp.Main;
using NUnit.Framework;
using tdd.oop.inheritance.CSharp.Main;
using tdd.oop.inheritance.CSharp.Main.LibraryItems;

namespace tdd.oop.inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void ShouldCheckOutIfAvailable()
        {
            IAuthor author = new Author();
            Book book = new("All About Muggles", author);

            Assert.AreEqual("item has been checked out", book.CheckOut());
        }

        [Test]
        public void ShouldDeclineIfNotAvailableToCheckout()
        {
            IAuthor author = new Author();
            Book book = new("All About Muggles", author); 

            book.CheckOut();

            Assert.AreEqual("item is currently on loan", book.CheckOut());
        }

        [Test]
        public void ShouldCheckInIfOnLoan()
        {
            IAuthor author = new Author();
            Book book = new("All About Muggles", author);

            book.CheckOut();

            Assert.AreEqual("item has been checked in", book.CheckIn());
        }

        [Test]
        public void ShouldDeclineCheckInIfNotOnLoan()
        {
            IAuthor author = new Author();
            Book book = new("All About Muggles", author);

            Assert.AreEqual("item is not currently on loan", book.CheckIn());
        }

        [Test]
        public void ShouldHaveAuthor()
        {
            IAuthor author = new Author();
            Book book = new("All About Muggles", author);

            author.Name = "J.K.R.";
            author.website = "wizardingworld.com";
            author.ContactInformation = "call assistant";



            Assert.IsTrue(book.Author.Name == "J.K.R.");
        }
    }
}