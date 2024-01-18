using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class LibraryTest
    {
        private Library _library = null;
        [SetUp]
        public void SetUp() {
            _library = new Library();
        }
        [Test]
        public void TestAddItemsToStock()
            {

                List<Author> authors = [new Author("test", "test", "test")];
                Article article = new Article("JUnit Rocks", authors);
                _library.addToStock(article);
                Assert.AreEqual(_library.Items.Count, 1);
            }

        [Test]
        public void TestCheckInItem()
            {
                Assert.AreEqual("item is not part of the library's collection", _library.checkInItem("Wrong"));
            }
        [Test]
        public void TestCheckInItemMoreThanOne()
            {
                List<Author> authors = [new Author("test", "test", "test")];
                Article article = new Article("JUnit Rocks", authors);
                _library.addToStock(article);
                Assert.AreEqual("item is not part of the library's collection", _library.checkInItem("Wrong"));
            }
    }
}