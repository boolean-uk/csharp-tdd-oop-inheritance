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
        public void shouldAddToStock()
        {
            //SetUp
            Library library = new Library();
            Book book = new Book(new Author("John", 50070090, "hi.com"), "JUnit Rocks");
            Article article = new Article(new Author("John", 50070090, "hi.com"), "JUnit Rocks");
            
            //Execute
            library.addToStock(book);
            library.addToStock(article);

            //Verify
            Assert.IsTrue(library.Articles.Contains(book));
            Assert.IsTrue(library.Articles.Contains(article));

        }

}
}
