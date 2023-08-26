// Author diye bir classımız olsun
// Yazar Adı
// Yazar soyadı.
// Kitap Adı
// Baskı Sayısı
using Encapsulation.Business;
using Encapsulation.Models;

Author author = new Author() { 

    AuthorName = "Gülsu",
    AuthorSurName = "Doğan",
    BasımYılı = 2023,
    BookName = "AbasıYanık kitabı"
};

Console.WriteLine(author);
AuthorEskiYontem author1 = new AuthorEskiYontem();
author1.SetAuthor("SAİT FAİK");
Console.WriteLine(author1.GetAuthor());
Console.WriteLine(author.AuthorName);
Console.WriteLine(author.AuthorSurName);
// Book classı olsun
// BookName
// BookTitle
// Price(double, decimal)
// Price %8 kdv uygulasın.

Book book = new();
book.BookName = "Kaşağı";
book.Price = 100;
Console.WriteLine(book.Price);

//BookManager manager = new();
//var bookByRules = manager.AddBook(book);
//Console.WriteLine(bookByRules);

//Book bk3 = new();
//bk3.Price = 120;

//BookManager2 manager2 = new();
//var bookByRules2 = manager2.AddBook(bk3);
//Console.WriteLine(bookByRules2);

IBookService bookService = new BookManager2();
var book1= bookService.AddBook(book);
Console.WriteLine(book1);