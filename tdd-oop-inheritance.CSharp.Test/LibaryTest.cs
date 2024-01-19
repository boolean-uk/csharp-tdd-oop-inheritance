using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibaryTest
{
        [Test]
        public void Test1()
        {
            Library library = new Library();
            Author author = new Author("cc", "cc@gmail.com", "https://www.cc.com");
            Book book = new Book("Junit Rocks", author);
            library.addToStock(book);

            string result = library.checkInItem("Junit Rocks");

            Assert.IsTrue(result == "item is not currently on loan");
            Assert.AreEqual(author, book.Author);
        }


        [Test]
        public void Test2()
        {
            Library library = new Library();
            Author author = new Author("cc", "cc@gmail.com", "https://www.cc.com");
            Book book = new Book("Junit Rocks", author);
            library.addToStock(book);

            string result = library.checkOutItem("Junit Rocks");

            Assert.AreEqual("item has been checked out", result);
            Assert.AreEqual(author, book.Author);

        }

        [Test]
        public void Test3()
        {
            Library library = new Library();
            Author author = new Author("cc", "cc@gmail.com", "https://www.cc.com");
            Article article = new Article("Introduction to C#", author);

            library.addToStock(article);

            string result = library.checkInItem("Introduction to C#");

            Assert.AreEqual("item is not currently on loan", result);
            Assert.AreEqual("cc", article.Author.Name);
            Assert.AreEqual("cc@gmail.com", article.Author.ContactInformation);
            Assert.AreEqual("https://www.cc.com", article.Author.Website);
        }
    }
}
