using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
     class AuthorTest
    {
        [Test]
        public void CheckAuthorArticle()
        {
            Author author = new Author("thanasis", "uk", "69999999");
            Article article = new Article("JUnit Rocks", author);
            article.addToStock(article);

            Assert.AreEqual("thanasis", article._author.Name);

            
        }
        [Test]
        public void CheckAuthorBook()
        {
            Author author = new Author("nigel", "uk", "69999999");
            Book book = new Book("JUnit Rocks", author);
            book.addToStock(book);

            Assert.AreEqual("nigel", book._author.Name);


        }
    }
}
