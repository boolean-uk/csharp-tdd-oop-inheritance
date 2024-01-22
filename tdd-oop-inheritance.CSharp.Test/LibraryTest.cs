using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    class LibraryTest
    {
        [Test]
        public void shouldAddItem()
        {
            Author martin = new Author("Martin", "91125241", "martin.no");
            Library library = new Library();
            Article article = new Article("JUnit Rocks", martin);;

            library.addToStock(article);

            Assert.That(library.libraryItems.Count, Is.EqualTo(1));
        }

        [Test]
        public void shouldNotCheckInBecauseNotCheckedOut()
        {
            Author martin = new Author("Martin", "91125241", "martin.no");
            Library library = new Library();
            Article article = new Article("JUnit Rocks", martin);;

            library.addToStock(article);
            string message = library.checkInLibraryItem("JUnit Rocks");

            Assert.That(message, Is.EqualTo("item is not currently on loan"));
        }


        [Test]
        public void shouldCheckIn()
        {
            Author martin = new Author("Martin", "91125241", "martin.no");
            Library library = new Library();
            Article article = new Article("JUnit Rocks", martin);;

            library.addToStock(article);
            library.checkOutLibraryItem("JUnit Rocks");
            string message = library.checkInLibraryItem("JUnit Rocks");

            Assert.That(message, Is.EqualTo("item has been checked in"));
        }


        [Test]
        public void shouldNotCheckOutBecauseNotInStock()
        {
            Author martin = new Author("Martin", "91125241", "martin.no");
            Library library = new Library();
            Article article = new Article("JUnit Rocks", martin);;
            article.checkOut();

            string message = library.checkInLibraryItem("JUnit Rocks");

            Assert.That(message, Is.EqualTo("item is not part of the library's collection"));
        }

    }
}
