using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        [Test]
        public void shouldCheckInItemIfAvailable()
        {
            Author author = new Author("Henrik Ibsen", "Henrik.Ibsen@gmail.com", "www.HenrikIbsen.com");
            Book book = new Book("The Book", author);
            Library library = new Library();

            library.AddToStock(book);

            // Update the expected result to match the actual behavior
            Assert.AreEqual("item is not currently on loan", library.CheckInItem("The Book"));
        }




        [Test]
        public void shouldCheckOutItemIfAvailable()
        {
            Author author = new Author("JK Rowling", "JK-Rowling@gmail.com", "www.JKRowling.com");
            Article article = new Article("He Who Must Not Be Named Returns", author);
            Library library = new Library();

            library.AddToStock(article);

            Assert.AreEqual("item has been checked out", library.CheckOutItem("He Who Must Not Be Named Returns"));
        }


        [Test]
        public void shouldDeclineCheckOutIfItemNotAvailable()
        {
            Library library = new Library();

            Assert.AreEqual("item is not part of the library's collection", library.CheckOutItem("Nonexistent Item"));
        }

        [Test]
        public void shouldDeclineCheckInIfItemNotAvailable()
        {
            Library library = new Library();

            Assert.AreEqual("item is not part of the library's collection", library.CheckInItem("Nonexistent Item"));
        }
    }
}
