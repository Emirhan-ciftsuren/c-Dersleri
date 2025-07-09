using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders2_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double Variables
            //            Console.WriteLine("***** Fiyat Listesi *****");
            //            double applePrice = 14.85;
            //            double orangePrice = 20.95;
            //            double strawberryPrice = 45;
            //            double potatoPrice = 9.74;
            //            double tomatoPrice = 6.88;
            //deneme dataası eklendi

            //            Conxsole.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //            Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //            Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //            Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //            Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice+ " TL");

            //            Console.WriteLine();

            //nsns
            //            Console.WriteLine();

            //            double appleGram = 1.245;
            //            double orangeGram=1,650;
            //            double strawberryGram = 0.750;
            //            double potatoGram = 4.859;
            //            double tomatoGram = 3.745;

            //            double appleTotalPrice = appleGram * applePrice;
            //            double orangeTotalPrice = orangeGram* orangePrice;
            //            double strawberryTotalPrice = strawberryGram* strawberryPrice;
            //            double potatoTotalPrice = potatoGram * potatoPrice;
            //            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //            Console.WriteLine("Alınan Ürün Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram +
            //"- Toplam tutar: " + appleTotalPrice);
            //            Console.WriteLine("Alınan Ürün Portakal - " + "Birim Fiyat: " + orangePrice+ " - Gramaj: " + orangeGram+
            //"- Toplam tutar: " + orangeTotalPrice);
            //            Console.WriteLine("Alınan Ürün Çilek - " + "Birim Fiyat: " + strawberryPrice+ " - Gramaj: " + strawberryGram+
            //"- Toplam tutar: " + strawberryTotalPrice);
            //            Console.WriteLine("Alınan Ürün Patates- " + "Birim Fiyat: " + potatoPrice+ " - Gramaj: " + potatoGram+
            //"- Toplam tutar: " + potatoTotalPrice);
            //            Console.WriteLine("Alınan Ürün Tomato - " + "Birim Fiyat: " + tomatoPrice+ " - Gramaj: " + tomatoGram+
            //"- Toplam tutar: " + tomatoTotalPrice);

            //            double shopingTotalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            Console.WriteLine("Alışveriş Toplam Tutar: "+shopingTotalPrice+" TL ");

            #endregion


            #region Char değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden veri girişleri string değişkenler
            //Console.WriteLine("*****C Sharp Hava Yolları Yolcu Bilgileri *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passnegerAge, passengerIdentityNumber;

            //Console.Write("Yolcu TC: ");
            //passengerIdentityNumber =  Console.ReadLine();

            //Console.Write("Yolcu Adı: "); 
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passnegerAge= Console.ReadLine();

            //Console.Write("İl: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Yolcu TC no: " + passengerIdentityNumber + " " + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + "Yaş: "+passnegerAge+ " - " + passengerDistrict + " / " + passengerCity);
            #endregion

            #region Klavyeden tam sayı girişleri ve dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + " TL");




            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3;

            //Console.Write("Birinci Sınav Notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("İkinci Sınav Notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Üçüncü Sınav Notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //double result = ((exam1 + exam2 + exam3) / 3);
            //Console.WriteLine();

            //Console.WriteLine("Ortalamanız: " + result);

            #endregion

            #region Klavyeden karakter girişleri

            //char gender;
            //Console.WriteLine("Lütfen Cinsiyetinizi girinizi.(Tek harf): ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Cinsiyetiniz: " + gender);



            #endregion

            Console.Read();
        }
    }
}
