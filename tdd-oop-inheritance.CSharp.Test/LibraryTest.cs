using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Test
{

    class LibraryTest
    { 

        [Test]
        public void LibraryAllTextsTest()
        {
            Author author = new Author("Bill Nye", "thescience@guy.com", "www.billnye.com");
            Article article = new Article("JUnit Rocks", author);
            Author bAuthor = new Author("JRR Tolkien", "tolkien@estate.com", "tolkienestate.com");
            Book book = new Book("JUnit Rocks", bAuthor);
            Newspaper newspaper = new Newspaper("The Daily Java");

            Assert.AreEqual("item is not currently on loan", article.checkIn());
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkOut());
            Assert.AreEqual("item is not currently on loan", book.checkIn());


        }
    }
}
