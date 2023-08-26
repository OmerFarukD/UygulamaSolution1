using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models;

public class Author
{
    private string name;
    private string surname;
    public string AuthorName
    {
        get
        {
            return name;
        }
        set
        {
            name = "Yazar adı : " + value + ".";
        }
    }
    public string AuthorSurName {

        get => surname;
        set => surname = "Yazar Soyadı : " + value + ".";
    }
    public string BookName { get; set; }
    public int BasımYılı { get; set; }

    public override string ToString()
    {
        return $"Adı : {AuthorName}, SOYAD : {AuthorSurName}, Kitap Adı : {BookName}"
          ;  }
}