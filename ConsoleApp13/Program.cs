 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        private static int lemonadePrice;

        static void Main(string[] args)
        {
            //  murat yücedağ c# kampı
            // yazdırma komutları 1.video
            //Console.Write("merhaba dünya");
            //Console.WriteLine("selam");
            //Console.Read();

            //Console.WriteLine("******Yemek Katagorileri****");
            //Console .WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("****** Yemek Katagorileri****");

            //değişkenler
            //string alfabetik türde verilerimizi tutabilmek için kullandığımız değişken türü
            //Değişken_türü deiğişken_adi;

            //string name;
            // name = "Pınar";
            // Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Pınar";
            //customerSurname = "Samet";
            //customerPhone = "+90 654 89 24";
            //customerEmail = " deneme@gmail.com";
            //district = "Aksaray";
            //city = "Aksaray";
            //Console.WriteLine("**** Rezervasyon kartı****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: "+customerEmail);
            //Console.WriteLine("Adres: "+district+"/"+city);
            //Console.WriteLine("-----------------------------");


            //int değişkenler
            //int tam sayı türündeki değişkenler
            //int number = 24;
            //Console.WriteLine(number); 

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("****Restoran Menü Fiyatı****");
            //Console.WriteLine();
            //Console.WriteLine("------Hamburger fiyatı: " + hamburgerPrice+"TL");
            //Console.WriteLine("------kola: "+cokePrice+"TL");
            //Console.WriteLine("------su: "+waterPrice+"TL");
            //Console.WriteLine("------kızartma: "+friesPrice+"TL");
            //Console.WriteLine("------pizza: "+pizzaPrice+"TL");
            //Console.WriteLine("-------limonata: "+lemonadePrice+"TL");
            //Console.WriteLine();
            //Console.WriteLine("****Restoran Menü Fiyatı****");

            //Console.WriteLine();
            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalHamburgerPrice;
            //int totalCokePrice;
            //int totalWaterPrice;
            //int totalFriesPrice;
            //int totalPizzaPrice;
            //int totalLemonadePrice;

            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;
            //totalHamburgerPrice =hamburgerCount* hamburgerPrice;
            //totalCokePrice=cokeCount* cokeCount;
            //totalWaterPrice = waterCount * waterPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;
            //totalFriesPrice = friesCount* friesPrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;

            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("hamburger tutarı: " + totalHamburgerPrice + "TL");
            //Console.WriteLine("Pizza tutarı: " + totalPizzaPrice + "TL");
            //Console.WriteLine("kızartma tutarı: " + totalFriesPrice + "TL");
            //Console.WriteLine("kola tutarı: "+totalCokePrice+"TL");
            //Console.WriteLine("limnata tutarı: " + totalLemonadePrice + "TL");
            //Console.WriteLine("su tutarı: " + totalWaterPrice + "TL");

            //Console.WriteLine();
            //int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamburgerPrice + totalPizzaPrice + totalFriesPrice;
            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");

            //2. video
            // double değişkenler 
            //double ondalıklı işlemler için kullanılan değişkenlerdir
            // double number;
            //  number = 4.85;
            // Console.WriteLine(number);

            //Console.WriteLine("***** FİYAT LİSTESİ******");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice =450;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("---- elma birim fiyatı: " + applePrice+"TL");
            //Console.WriteLine("---- portakal birim fiyatı: " + orangePrice+"TL");
            //Console.WriteLine("---- çilek birim fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("---- patates birim fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("---- domates birim fiyatı: " + tomatoPrice + "TL");


            //double appleGram, orangeGram, strawberryGram, potatoGram,tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.657;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.743;
            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("Elmanın Toplam Fiyatı: " + appleTotalPrice);


            //char değişkenleri
            // char değişkenleri tek tırnak ile tanımlanır.  '
            //char symbol;
            //symbol= 'A';
            //Console.WriteLine(symbol);



            // klavyeden veri girişleri string değişkenler
            //Console.WriteLine("**** csharp hava yolları yolcu bilgisi***");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //   passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName=Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname=Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity=Console.ReadLine();

            //Console.Write("İlçe bilgisi: ");
            //passengerDistrict=Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge=Console.ReadLine();

            //Console.Write("Yolvu TC Kimlik No:");
            //passengerIdentityNumber=Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------");
            //Console.WriteLine("Yolcu: "+passengerName+" "+passengerSurname+" " +passengerCity+" "+passengerDistrict+" "+passengerIdentityNumber); ;

            // Klavyeden tam sayı girişleri ve dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 2000;
            //chairPrice = 5000;
            //tvPrice = 1200;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız ayakkabının fiyatını giriniz: ");
            //shoesCount= int.Parse(Console.ReadLine());
            ////parse dönüştürmek için kullanılan bir method
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalya sayısını giriniz: ");
            //chairCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvPrice= int.Parse(Console.ReadLine());

            //int totalPrice= shoesCount*shoesPrice+computerPrice*computerCount+chairCount*chairPrice+tvPrice*tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);


            //klayveden onalıklı sayı işlemleri

            //double exam1,exam2,exam3, result;
            //Console.Write("Lütfen 1. sınav notunu girin: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfe 2. sınav notunu giriniz: ");
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3=double.Parse(Console.ReadLine());

            //result=(exam1 + exam2+exam3 ) / 3;

            //Console.WriteLine();
            //Console.WriteLine("sınav ortalamanız: "+result);



            // klavyeden karakter girişleri 
            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Seçtiğiniz cinsiyet: " + gender);



            // 3. videoooo
            //























            Console.ReadLine();













        }
    }
}
