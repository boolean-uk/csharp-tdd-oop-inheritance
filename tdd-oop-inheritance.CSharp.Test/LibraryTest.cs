using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryTest
    {
        Author author = new Author("Jane", "Test", "www.Jane.com");


        [Test]
        public void ShouldCheckOutIfAvailable()
        {

            Material material = new Book ("JUnit Rocks", author);
            string result = material.checkOut();

            if (!(material is Newspaper))
            {
                // Modify this assertion based on the expected behavior of your checkOut method.
                Assert.AreEqual("item has been checked out", result);
            }
            else
            {
                Assert.AreEqual("newspapers are not available for loan", result);
            }
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Material materialBook = new Book("JUnit Rocks 2", author);
            string result1 = materialBook.checkOut();

            if(!(materialBook is Newspaper))
            {
                Assert.AreEqual("item is currently on loan", materialBook.checkOut());
            }
            else
            {
                Assert.AreEqual("newspapers are not available for loan", result1);
            }
        }



        [Test]
        public void ShouldCheckInIfAvailable()
        {

            Material materialNewspaper = new Newspaper("JUnit Rocks");
            materialNewspaper.checkOut();
            string result2 = materialNewspaper.checkIn();

            if (!(materialNewspaper is Newspaper))
            {
                // Modify this assertion based on the expected behavior of your checkOut method.
                Assert.AreEqual("item has been checked in", result2);
            }
            else
            {
                Assert.AreEqual("newspapers are not available for loan", result2);
            }
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Material materialArticle = new Article("JUnit Rocks", author);
            string result3 = materialArticle.checkIn();


            if (!(materialArticle is Newspaper))
            {
                // Modify this assertion based on the expected behavior of your checkOut method.
                Assert.AreEqual("item is not currently on loan", result3);
            }
            else
            {
                Assert.AreEqual("newspapers are not available for loan", result3);
            }
            
        }



        [Test]
        public void addToStockTest()
        {
            Library library = new Library();
            Material materialNewest = new Material("JUnit Rocks");
            library.addToStock(materialNewest);
            List<Material> list = library.getElements();

            Assert.That(library.getElements().Count(), Is.EqualTo(1));
            Assert.That(list[0].getTitle(), Is.EqualTo("JUnit Rocks"));

        }
      

      
    }
}
