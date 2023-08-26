using Encapsulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Business;

internal class BookManager2 : IBookService
{
    public Book AddBook(Book book)
    {
        return book;
    }

    public void EkranaYaz(int a)
    {
        Console.WriteLine(a+2);
    }
}
