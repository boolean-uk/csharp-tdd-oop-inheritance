using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    class LibraryTest
    {
        
        [Test]
        public void ShouldBookAddToStock()
        {
            Library library = new Library();
            Author author = new Author("John Doe", "Website", "@here");
            Book book = new Book(author, "C# fun");

            library.addToStock(book);
            bool expected = true;

            bool result = false;

            if (library.items.Contains(book)) 
            {
                result = true;
            }

            Assert.AreEqual(expected, result);
            
        }

        [Test]
        public void ShouldAddArticleToStock()
        {
            Library library = new Library();
            Author author = new Author("Jane Doe", "Website", "@here");
            Article article = new Article(author, "This article is a non issue");

            library.addToStock(article);
            bool expected = true;

            bool result = false;

            if (library.items.Contains(article))
            {
                result = true;
            }

            Assert.IsTrue(result == expected);

        }

        [Test]
        public void ShouldAddToStock()
        {
            Library library = new Library();
            Newspaper paper = new Newspaper("The Daily Journal");

            library.addToStock(paper);
            bool expected = true;

            bool result = false;

            if (library.items.Contains(paper))
            {
                result = true;
            }

            Assert.IsTrue(result == expected);

        }

        [Test]
        public void ShouldPrintArticleAuthor()
        {
            Library library = new Library();
            Author author = new Author("John Doe", "Website", "@here");
            Article article = new Article(author, "Hot take - Python is older than Java");

            library.addToStock(article);
            string expected = "John Doe";

            string result = library.AuthorInfo("Hot take - Python is older than Java");

            Assert.AreEqual(expected, result);

        }

        [Test]
        public void ShouldPrintBookAuthor()
        {
            Library library = new Library();
            Author author = new Author("John Doe", "Website", "@here");
            Book book = new Book(author, "C# fun");

            library.addToStock(book);
            string expected = "John Doe";

            string result = library.AuthorInfo("C# fun");

            Assert.AreEqual(expected, result);

        }
    }
}