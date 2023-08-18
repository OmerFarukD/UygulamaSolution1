// Ve veya 
//  & -> Ve 
// | -> Veya 
Console.WriteLine(1|1);
Console.WriteLine(0|1);
Console.WriteLine(true | true);
Console.WriteLine(0 & 1);

// if - else 


// == -> eşit mi 
// != -> eşit değil mi 
int sayi = 20;

if (sayi > 20)
{
    Console.WriteLine("sayı 20 den büyüktür.");
}
else if (sayi ==20)
{
Console.WriteLine("Sayı 20 ye eşittir.");
}

else
{
    Console.WriteLine("Sayı 20 den küçüktür.");
}

// vize notu 55 den küçükse kaldınız
// 55 ten büyükse geçtiniz
//100 ise tam puan aldınız.
int vizeNotu = 100;
if (vizeNotu < 55)
{
    Console.WriteLine("Kaldınız.");
}
else if(vizeNotu ==100)
{
    Console.WriteLine("Tam puan aldınız.");
}
else if(vizeNotu >55)
{
    Console.WriteLine("Geçtiniz.");
}

// kullanıcıdan yaşını alsın ve ehliyet alabilr mi alabiliyorsa ehliyet alabilir
//alamazsa ehliyet alamaz.

//Console.WriteLine("Lütfen yaşınızı girin : ");
//int age = Convert.ToInt32(Console.ReadLine());

//if(age >= 18)
//{
//    Console.WriteLine("Ehliyet alabilir");
//}
//else
//{
//    Console.WriteLine("Ehliyet alamaz.");
//}

// HAFTANIN 1. GÜNÜ PAZARTESİ 2. GÜN SALI ... 

Console.WriteLine("Haftanın kaçıncı gününün adını öğrenmek istiyorsunuz :");
int day = Convert.ToInt32(Console.ReadLine());
if (day <= 5 && day >= 1)
{
    Console.WriteLine("Hafta içi-");
}
else if (day>=6 && day <=7)
{
    Console.WriteLine("Hafta sonu-");
}
if (day==1)
{
    Console.WriteLine("Günlerden pazartesidir.");
}
else if (day == 2)
{
    Console.WriteLine("Günlerden salıdır.");
}
else if ( day ==6)
{
    Console.WriteLine("Günlerden Cumartesi");
}
else if (day == 7)
{
    Console.WriteLine("Günlerden Pazar");
}





