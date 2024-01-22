using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTests
    {
        [Test]
        public void LibraryTest_01_Npaper()
        {
            Library library = new Library();
            Newspaper newspaper = new Newspaper("Duckburg Times");
            library.addToStock(newspaper);

            Assert.That(library.literature.Count, Is.EqualTo(1));
        }

        [Test]
        public void LibraryTest_02_Article()
        {
            Library library = new Library();
            Article article = new Article("Top 10 Sodastream flavours");
            library.addToStock(article);

            Assert.That(library.literature.Count, Is.EqualTo(1));
        }

        [Test]
        public void LibraryTest_03_Book()
        {
            Library library = new Library();
            Book book = new Book("Moby Dick 2: Electric boogaloo");
            library.addToStock(book);

            Assert.That(library.literature.Count, Is.EqualTo(1));
        }

        [Test]
        public void LibraryTest_04_OneOfEach()
        {
            Library library = new Library();
            Newspaper newspaper = new Newspaper("Duckburg Times");
            Article article = new Article("Top 10 Sodastream flavours");
            Book book = new Book("Moby Dick 2: Electric boogaloo");
            library.addToStock(article);
            library.addToStock(newspaper);
            library.addToStock(book);

            Assert.That(library.literature.Count, Is.EqualTo(3));
        }

        [Test]
        public void LibraryTest_05_CheckOut_Book()
        {
            Library library = new Library();
            Book book = new Book("Moby Dick 2: Electric boogaloo");
            library.addToStock(book);

            string expectedResult = library.checkOutLiterature("Moby Dick 2: Electric boogaloo");
            string actualResult = "item has been checked out";
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void LibraryTest_06_CheckOut_BookAlreadyLoaned()
        {
            Library library = new Library();
            Book book = new Book("Moby Dick 2: Electric boogaloo");
            library.addToStock(book);
            library.checkOutLiterature("Moby Dick 2: Electric boogaloo");

            string expectedResult = library.checkOutLiterature("Moby Dick 2: Electric boogaloo");
            string actualResult = "item is currently on loan";
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void LibraryTest_06_CheckOut_BookNotInLibrary()
        {
            Library library = new Library();

            string expectedResult = library.checkOutLiterature("Moby Dick 2: Electric boogaloo");
            string actualResult = "item is not part of the library's collection";
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void LibraryTest_07_CheckOut_Newspaper()
        {
            Library library = new Library();
            Newspaper newspaper = new Newspaper("Duckburg Times");
            library.addToStock(newspaper);

            string expectedResult = library.checkOutLiterature("Duckburg Times");
            string actualResult = "newspapers are not available for loan";
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}
