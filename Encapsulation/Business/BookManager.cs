using Encapsulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Business;

public class BookManager : IBookService
{
    public Book AddBook(Book book)
    {
        book.Price = book.Price * 1.08;
        book.BookName = book.BookName + ".";
        return book;
    }

    public void EkranaYaz(int a)
    {
        Console.WriteLine(a);
    }
    // Ioc 
}
