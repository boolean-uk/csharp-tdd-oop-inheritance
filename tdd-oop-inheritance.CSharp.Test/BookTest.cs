using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class BookTest
    {
        private Author _author;
        private Book _book;

        [SetUp]
        public void Setup()
        {
            _author = new Author("John Doe" , "johndoe@example.com" , "www.johndoe.com");
            _book = new Book("A Great Book" , _author);
        }

        [Test]
        public void ShouldCheckOutIfAvailable()
        {
            Assert.AreEqual("item has been checked out" , _book.CheckOut());
        }

        [Test]
        public void ShouldDeclineIfNotAvailableToCheckout()
        {
            _book.CheckOut();
            Assert.AreEqual("item is currently on loan" , _book.CheckOut());
        }

        [Test]
        public void ShouldCheckInIfOnLoan()
        {
            _book.CheckOut();
            Assert.AreEqual("item has been checked in" , _book.CheckIn());
        }

        [Test]
        public void ShouldDeclineCheckInIfNotOnLoan()
        {
            Assert.AreEqual("item is not currently on loan" , _book.CheckIn());
        }

        [Test]
        public void ShouldHaveCorrectAuthor()
        {
            Assert.AreEqual(_author , _book.Author);
        }
    }
}