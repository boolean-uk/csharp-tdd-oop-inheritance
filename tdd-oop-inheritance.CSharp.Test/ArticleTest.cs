using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {
            Author author = new Author()
            {
                _name = "test",
                _contactInformation = "123",
                _website = "test.com",
            };
            Article article = new Article("JUnit Rocks", author);
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
            Author author = new Author()
            {
                _name = "test",
                _contactInformation = "123",
                _website = "test.com",
            };
            Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
            Author author = new Author()
            {
                _name = "test",
                _contactInformation = "123",
                _website = "test.com",
            };
            Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
            Author author = new Author()
            {
                _name = "test",
                _contactInformation = "123",
                _website = "test.com",
            };
            Article article = new Article("JUnit Rocks", author);

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }

        [Test]
        public void verifyAuthorHasBeenAdded()
        {
            // arrange
            Author author = new Author()
            {
                _name = "test",
                _contactInformation = "123",
                _website = "test.com",
            };
            string title = "test";

            // act
            Article article = new Article(title, author);

            // assert
            Assert.That(article._author._name, Is.EqualTo(author._name));
            Assert.That(article._author._contactInformation, Is.EqualTo(author._contactInformation));
            Assert.That(article._author._website, Is.EqualTo(author._website));
        }
    }
}