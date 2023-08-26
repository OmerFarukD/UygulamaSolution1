// See https://aka.ms/new-console-template for more information
// E ticaret sistemimiz var ve bu sistemde ürün kaydı yapmamız isteniyor.

// Ürün adı , Üreticisi, Fiyatı , Stok, Açıklama

using OOP_GIRIS.Models;

Product product = new Product();

Product product2 = new();
// Refflection yöntemi ile nesner oluşturma 

//product.name = "Ürün1";
//product.producer = "Seyfi Yalçınses";
//product.description = "9 yıl oldu.";
//product.price = 10;
//product.stock = 15;

//Console.WriteLine(product.name);
//Console.WriteLine(product.producer);
//Console.WriteLine(product.description);
//Console.WriteLine(product.price);
//Console.WriteLine(product.stock);

Console.WriteLine(product);
//var product1 = new Product("Bilgisayar", "Vatan Computer", 20, 10, "Bilgisayar");
//Console.WriteLine(product1);
var product3 = new Product("Telefon",20000);
Console.WriteLine(product3.ToString());
// Cateory diye bir class oluşturun  
// CategoryName , Description
// NoArgs ve All Args Constructor olsun
Category category = new Category();
category._categoryName = "Kitap";
category._categoryDescription = "Deneme açıklaması";
Console.WriteLine(category);
Category category2 = new("asd","deneme");
Console.WriteLine(category2);

