using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryTest
    {
        private Library _library;
        private Book _book;
        private Article _article;
        private Newspaper _newspaper;

        [SetUp]
        public void Setup()
        {
            _library = new Library();
            _book = new Book("A Great Book");
            _article = new Article("An Interesting Article");
            _newspaper = new Newspaper("Today's News");
        }

        [Test]
        public void ShouldAddItemsToStock()
        {
            _library.AddToStock(_book);
            _library.AddToStock(_article);
            _library.AddToStock(_newspaper);

            Assert.AreEqual("item has been checked out" , _library.CheckOut("A Great Book"));
            Assert.AreEqual("item has been checked out" , _library.CheckOut("An Interesting Article"));
            Assert.AreEqual("newspapers are not available for loan" , _library.CheckOut("Today's News"));
        }

        [Test]
        public void ShouldCheckInAndOutItems()
        {
            _library.AddToStock(_book);
            _library.AddToStock(_article);

            Assert.AreEqual("item has been checked out" , _library.CheckOut("A Great Book"));
            Assert.AreEqual("item has been checked in" , _library.CheckIn("A Great Book"));

            Assert.AreEqual("item has been checked out" , _library.CheckOut("An Interesting Article"));
            Assert.AreEqual("item has been checked in" , _library.CheckIn("An Interesting Article"));
        }

        [Test]
        public void ShouldNotFindNonexistentItems()
        {
            Assert.AreEqual("item is not part of the library's collection" , _library.CheckOut("Nonexistent Book"));
            Assert.AreEqual("item is not part of the library's collection" , _library.CheckIn("Nonexistent Book"));
        }
    }

}
