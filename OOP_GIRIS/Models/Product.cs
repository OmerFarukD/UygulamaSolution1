using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GIRIS.Models;
public class Product
{
    public Product()
    {

    }
    public Product(string name , decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public Product(string name, string producer, decimal price,int stock,string description )
    {
        // this , base 
        name = name;
       producer = producer;
        price = price;
        stock = stock;
        description = description;
    }

    public string name;
    internal string producer;
    public decimal price;
    public int stock;
    public string  description;

    public override string ToString()
    {
        return $"Ürün adı : {this.name}, Sağlayıcı : {this.producer} " +
            $"Değeri : {this.price}, Stok : {this.stock}, Açıklama : {this.description}";
    }

}
