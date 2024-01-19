using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;
using tdd_oop_inheritance.CSharp.Main.Core;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        [Test]
        public void LibTest()
        {
            List<Item> items = new List<Item>();
            Article article = new Article("JUnit Rocks");
            Book book = new Book("Lord of the Rings");
            Newspaper news = new Newspaper("Weasle News");

            items.Add(article);
            items.Add(book);
            items.Add(news);

            Assert.AreEqual(3, items.Count());
            Assert.AreEqual("item is not currently on loan", book.CheckIn());
            Assert.AreEqual("newspapers are not available for loan", news.CheckOut());
            Assert.AreEqual("item is not currently on loan", article.CheckIn());
        }
    }
}
