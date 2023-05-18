// See https://aka.ms/new-console-template for more information
using tdd_oop_inheritance.CSharp.Main;

Console.WriteLine("Hello, World!");

Author author = new Author("thanasis", "uk", "69999999");
Article article = new Article("JUnit Rocks", author);
article.addToStock(article);

foreach (var item in article.Articles)
{
    Console.WriteLine(item._author.Name);
}