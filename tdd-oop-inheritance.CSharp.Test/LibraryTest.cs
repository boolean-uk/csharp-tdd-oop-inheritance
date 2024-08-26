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
            Book book = new Book("C# is the thing");

            library.addToStock(book);
            bool expected = true;

            bool result = false;

            if (library.items.Contains(book)) 
            {
                result = true;
            }

            Assert.IsTrue(result == expected);
            
        }

        [Test]
        public void ShouldAddArticleToStock()
        {
            Library library = new Library();
            Article article = new Article("This article is a non issue");

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
    }
}