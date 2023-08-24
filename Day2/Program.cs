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

//Console.WriteLine("Haftanın kaçıncı gününün adını öğrenmek istiyorsunuz :");
//int day = Convert.ToInt32(Console.ReadLine());
//if (day <= 5 && day >= 1)
//{
//    Console.WriteLine("Hafta içi-");
//}
//else if (day>=6 && day <=7)
//{
//    Console.WriteLine("Hafta sonu-");
//}
//if (day==1)
//{
//    Console.WriteLine("Günlerden pazartesidir.");
//}
//else if (day == 2)
//{
//    Console.WriteLine("Günlerden salıdır.");
//}
//else if ( day ==6)
//{
//    Console.WriteLine("Günlerden Cumartesi");
//}
//else if (day == 7)
//{
//    Console.WriteLine("Günlerden Pazar");
//}

//Console.WriteLine("1. Sayıyı giriniz.");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2 . Sayıyı giriniz");
//int sayi2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("İşlem Seçiniz: \n +- Toplama \n (-)-Çıkarma" +
//    "\n (*)-Çarpma " +
//    "\n (/)-Bölme");

//string @operator = Console.ReadLine();
// if else ile kullanımı
//if (@operator.Equals("+"))
//    Console.WriteLine($"2 sayının toplamı = {sayi1 + sayi2}");
//else if (@operator.Equals("-"))
//    Console.WriteLine($"2 sayının farkı = {sayi1 - sayi2}");
//else if (@operator == "*")
//    Console.WriteLine($"2 Sayını çarpımı = {sayi1 * sayi2}");
//else if (@operator == "/")
//    Console.WriteLine($"2 Sayının Bölümü = {sayi1 / sayi2}");
//else Console.WriteLine("Geçersiz karakter girdiniz.");

//switch (@operator)
//{
//    case "+":
//        Console.WriteLine($"2 sayının toplamı = {sayi1 + sayi2}");
//        break;
//    case "-":
//        Console.WriteLine($"2 sayının farkı = {sayi1 - sayi2}");
//        break;
//    case "*":
//        Console.WriteLine($"2 Sayını çarpımı = {sayi1 * sayi2}");
//        break;
//    case "/":
//        {
//            if(sayi2 ==0)
//            {
//                Console.WriteLine("2. Sayı 0 olamaz");
//            }
//            else
//            {
//                Console.WriteLine($"2 Sayının Bölümü = {sayi1 / sayi2}");
            
//            }
//            break;
//        }
       

//    default:
//        Console.WriteLine("Geçersiz karakter girdiniz");
//        break;
//}

// Cololections 
int[] sayilar = {1,2,3,4,6,10,11,12,2,5,6};
Console.WriteLine($"3. Sayı {sayilar[2]}");
Console.WriteLine($"Dizinin Boyutu : {sayilar.Length}");
Console.WriteLine($"Dizinin en büyük elemanı : {sayilar.Max()}");
Console.WriteLine($"Dizinin en küçük elemanı : {sayilar.Min()}");
Console.WriteLine($"Dizinin tipi nedir : {sayilar.GetType()}");

List<int> sayilarListesi = new List<int>() {1,2,3};
sayilarListesi.Add(2);
sayilarListesi.Remove(3);
Console.WriteLine($"sayılar Listesinin Boyutu : {sayilarListesi.Count}");
// Generic programing
List<string> sehirler = new();
sehirler.Add("Elazığ");
sehirler.Add("Malatya");
sehirler.Add("Bingöl");
sehirler.Add("Tunceli");
Console.WriteLine($"Şehirler listesinin Boyutu : {sehirler.Count}");
Console.WriteLine(sehirler);


// for döngüsü yöntemi ile 
for (int i =0; i<sehirler.Count;i++)
{
    Console.WriteLine($"{i+1}. Şehir = {sehirler[i]}");
}

//foreach
foreach (string sehir in sehirler) { 
    Console.WriteLine(sehir);
}

// Meyve Listesi tutan bir Liste oluşturun ve ekrana bütün meyveleri getiren foreach döngüsünü kullanın
// bir sınav notu listesi olsun ve bu sınav notu listesinin for döngüsü ile ekrana yazdırın.

List<string> meyveler = new() { "Elma","Üzüm","Karpuz"};
foreach (string item in meyveler)
{
    Console.WriteLine(item);
}

List<int> notes = new List<int> { 10,20,30};
for (int i= 0;i<notes.Count;i++)
{
    Console.WriteLine(notes[i]);
}
Console.WriteLine("2. Yöntem");
meyveler.ForEach(item=>Console.WriteLine(item));
// LINQ Language Integrated Query

// Elimizde 1 tane liste olsun Bu liste de çift sayı olanları farklı bir listeye atsın ve o çift sayı listesini ekrana bastırsın
List<int> numbers = new() {1,2,3,4,5,6,7,8,9,10};
List<int> evenNumbers = new();
List<int> oddNumbers = new();
//foreach (int number in numbers)
//{
//    if (number % 2==0)
//    {
//        evenNumbers.Add(number);
//    }
//    else
//    {
//      oddNumbers.Add(number);
//    }
//}

//oddNumbers = numbers.FindAll(odd=> odd%2!=0);
//evenNumbers = numbers.FindAll(e=> e%2==0);
//numbers.FindAll(odd => odd % 2 != 0).ForEach(x=> Console.WriteLine(x));
//Console.WriteLine("Çift Sayılar");
//evenNumbers.ForEach(even => Console.WriteLine(even));
//Console.WriteLine("Tek sayılar");
//oddNumbers.ForEach(x => Console.WriteLine(x));

// Kullanıcıdan 10 dan büyük sayı alana kadar Kullanıcıdan sayı almaya devam etsin

Console.WriteLine("Lütfen Sayı giriniz.");
int deger = Convert.ToInt32(Console.ReadLine());

while (deger<10)
{
    Console.WriteLine("Lütfen Sayı giriniz.");
    deger = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("10 DAN BÜYÜK BİR SAYI GİRİNİZ.");
}
Console.WriteLine(deger);
