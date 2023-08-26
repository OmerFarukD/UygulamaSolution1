using Encapsulation.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models;

public class Book
{
 
    public string BookName { get; set; }
    public string BookTitle { get; set; }
    public double Price { get; set; }


    public override string ToString()
    {
        return $"Adı  : {BookName}, Değeri : {Price}";
            }


}
