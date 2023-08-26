using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GIRIS.Models;
// Single Responsibility
public class Product
{


    // No Args Constructor
    public Product() 
    {

    }
    public Product(string name , decimal price)
    {
        _name = name;
        _price = price;
    }
    // All args Constructor
    public Product(string name, string producer, decimal price, int stock, string description) : this()
    {
        _name = name;
        _producer = producer;
        _price = price;
        _stock = stock;
        _description = description;
            
    }

    public string _name;
    internal string _producer;
    public decimal _price;
    public int _stock;
    public string  _description;

    public override string ToString()
    {
        return $"Ürün adı : {_name}, Sağlayıcı : {_producer} " +
            $"Değeri : {_price}, Stok : {_stock}, Açıklama : {_description}";
    }
    //public string EkranaYaz()
    //{
    //    return $"Ürün adı : {_name}, Sağlayıcı : {_producer} " +
    //        $"Değeri : {_price}, Stok : {_stock}, Açıklama : {_description}";
    //}


}