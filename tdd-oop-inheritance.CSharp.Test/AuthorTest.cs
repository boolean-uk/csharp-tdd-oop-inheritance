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
    public class AuthorTest
    {
        [Test]
        public void testAuthor1()
        {
            //Arrange
            Author author = new Author() { Name = "Kanthee", Contact = "I dont know", Website = "Find it" };
            Book book = new Book(author) { Title = "JUnit Rocks" };


            //Act
            string testNameAuthor = book._author.Name;
            string testNameBook = book._author.Contact;

            //Assert
            Assert.IsTrue(testNameAuthor == "Kanthee" && testNameBook == "I dont know");

        }

        [Test]
        public void testAuthor2()
        {
            //Arrange
            Author author = new Author() { Name = "Kanthee", Contact = "I dont know", Website = "Find it" };

            Article article = new Article(author) { Title = "JUnit Rocks" };


            //Act
            string testNameAuthor = article._author.Name;
            string testNameBook = article._author.Contact;

            //Assert
            Assert.IsTrue(testNameAuthor == "Kanthee" && testNameBook == "I dont know");

        }

    }



}
