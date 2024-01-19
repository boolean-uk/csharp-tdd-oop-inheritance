using NUnit.Framework;
using Objects;
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
        public void testAdd()
        {
            //Arrange
            Author author = new Author() { Name = "Kanthee", Contact = "I dont know", Website = "Find it" };
            Book book = new Book(author) { Title = "JUnit Rocks" };
            Newspaper newspaper = new Newspaper() { Title = "The Daily Java" };
            Library library = new Library();

            //Act
            library.addToStock(book);
            library.addToStock(newspaper);

            //Assert
            Assert.IsTrue(library._publications.Count == 2);

        }

        [Test]
        public void testCheckIn()
        {
            //Arrange
            Author author = new Author() { Name = "Kanthee", Contact = "I dont know", Website = "Find it"};
            Book book = new Book(author) { Title = "JUnit Rocks" };
            Newspaper newspaper = new Newspaper() { Title = "The Daily Java" };
            Library library = new Library();
            library.addToStock(book);
            library.addToStock(newspaper);

            //Act


            //Assert
            Assert.AreEqual(library.checkIn("JUnit Rocks"), "item is not currently on loan");

        }

        [Test]
        public void testCheckOut()
        {
            //Arrange
            Author author = new Author() { Name = "Kanthee", Contact = "I dont know", Website = "Find it" };
            Book book = new Book(author) { Title = "JUnit Rocks" };
            Newspaper newspaper = new Newspaper() { Title = "The Daily Java" };
            Library library = new Library();
            library.addToStock(book);
            library.addToStock(newspaper);

            //Act


            //Assert
            Assert.AreEqual(library.checkOut("JUnit Rocks"), "item has been checked out");

        }


    }

}

