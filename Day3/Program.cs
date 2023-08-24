//Console.WriteLine("Lütfen Sayı giriniz.");
//int deger = Convert.ToInt32(Console.ReadLine());

//while (deger < 10)
//{
//    Console.WriteLine("10 DAN BÜYÜK BİR SAYI GİRİNİZ.");
//    deger = Convert.ToInt32(Console.ReadLine());
    
//}
//Console.WriteLine(deger);

// while döngüsü kullanarak 1 den 10 a kadar sayıları ekrana bastıran kodu yazınız
int sayi1 = 1;
//while (sayi1<=10)
//{
//    Console.WriteLine(sayi1);
//    //sayi1 = sayi1 + 1;
//    // sayi1++;
//    sayi1 += 1;



//}


//string ad = "Furkan";
//string soyad = "Oğuz";
//IsimYazdir(ad, soyad);
//IsimYazdir(soyad:"Doğan",ad:"Ömer");
//IsimYazdir(soyad: soyad, ad: ad);
//IsimYazdir("Mauro","Icardi");
//Topla(2,3);
//Topla(45, 54);
//Faktoriyel(6);
//Console.WriteLine(ToplaDegerDonduren(2, 3));
//int toplamSonucu = ToplaDegerDonduren(10,10);
//Console.WriteLine(toplamSonucu);

//Console.WriteLine(IsimYazdirDegerDonduren(ad,soyad));

//string isimSonucu = IsimYazdirDegerDonduren("Fatih","Terim");
//Console.WriteLine(isimSonucu);


//void Topla(int a , int b)
//{
//    Console.WriteLine($"{a} + {b} = {a+b}");
//}

//// Faktoriyel diye bir metod yazın parametre olarak int değer alsın ve sonucu ekrana bastırsın
//// Faktoriyel(5);  120

//void Faktoriyel(int a)
//{
//    int sonuc = 1;

//    for (int i = 1; i <= a; i += 1)
//    {
//        //sonuc = sonuc * i;
//        sonuc *= i;
//    }
//    Console.WriteLine(sonuc);
//}





//Console.WriteLine();



//void IsimYazdir(string ad , string soyad)
//{
//    Console.WriteLine($"Ad :{ad} , Soyad : {soyad} ");
//}


//int ToplaDegerDonduren(int a , int b)
//{
//    return a + b;
//}

//string IsimYazdirDegerDonduren(string ad , string soyad)
//{
//    return $" Ad  : {ad}, Soyad : {soyad}";
//}


// switch case ve fonksiyonları kullanarak basit bir hesap makinesi uygulaması yapalım.
// 1. Toplama

Console.WriteLine("Birinci sayıyı giriniz.");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz.");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1.Toplama \n 2. Çarpma \n 3. Bölme \n 4. Çıkarma");
int islem = Convert.ToInt32(Console.ReadLine());

switch (islem)
{
    case 1:
        ToplaSwitch(number1,number2);
        break;
        case 2:
        CarpSwitch(number1,number2);
        break;
        case 3:
        {
            if (number2 == 0)
            {
                Console.WriteLine("Payda 0 olamaz");
            }
            else
            {
                Console.WriteLine(Bolme(number1, number2)); 
            }
            break;
        }
        case 4:
        Cikar(number1,number2);
        break;

    default:
        Console.WriteLine("Geçersiz karakter girdiniz.");
        break;
}



void ToplaSwitch(int a , int b)
{
    Console.WriteLine(a+b);
}

void CarpSwitch(int a, int b)
{
    Console.WriteLine(a * b);
}

int Bolme(int a , int b)
{
    return a / b;
}

int Cikar(int a ,int b)
{
    return a - b;
}