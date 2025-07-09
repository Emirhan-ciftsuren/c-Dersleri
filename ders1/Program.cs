using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region yazdırmaKomutları
            //Console.Write("hello world");

            //Console.WriteLine("******* Yemek Kategorileri *******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar ");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("******* Yemek Kategorileri *******");
            #endregion

            #region değişkenlerString

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city ;

            //customerName = "Emirhan";
            //customerSurname = "Çiftsüren";
            //customerPhone = "+90 532 413 87 83";
            //customerEmail = "emircftsrn@gmail.com";
            //district = "Artuklu";
            //city = "Mardin";

            //Console.WriteLine("****** Rezervasyon Kartı ******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri: "+customerName+" "+customerSurname);

            //Console.WriteLine("İletişim: "+customerPhone);   
            //Console.WriteLine("Email Adresi: "+customerEmail);       
            //Console.WriteLine("Adres: "+district+", "+city);
            //Console.WriteLine("----------------------------------------------");

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);

            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + ", " + city);
            //Console.WriteLine("----------------------------------------------");







            #endregion

            #region intDeğişkenler
            int hamburgerprice = 300;
            int pizzaprice = 35;
            int cokeprice = 10;
            int lemonadeprice = 50;
            int friesprice = 250;
            int waterprice = 30;
            //---------------------------------------------------
            int hamburgerCount = 3;
            int pizzaCount = 0;
            int cokeCount = 2;
            int lemonadeCount = 1;
            int friesCount = 2;
            int waterCount = 2;


            Console.WriteLine("******* Restoran Menü Fiyatı *******");
            Console.WriteLine("-----Hamburger (adet): " + hamburgerprice + " X " + hamburgerCount);
            Console.WriteLine("-----Pizza (adet): " + pizzaprice + " X " + pizzaCount);
            Console.WriteLine("-----Kola (adet): " + cokeprice + " X " + cokeCount);
            Console.WriteLine("-----Limonata (adet): " + lemonadeprice + "  X " + lemonadeCount);
            Console.WriteLine("-----Kızartma (adet): " + friesprice + " X " + friesCount);
            Console.WriteLine("-----Su (adet): " + waterprice + "X" + waterCount);




            int totalhamburgerprice = hamburgerprice * hamburgerCount;
            int totalpizzaprice = pizzaprice * pizzaCount;
            int totalcokeprice = cokeprice * cokeCount;
            int totallemonadeprice = lemonadeprice * lemonadeCount;
            int totalfriesprice = friesprice * friesCount;
            int totalwaterprice = waterprice * waterCount;


            int totalprice = totalhamburgerprice + totalcokeprice + totallemonadeprice + totalfriesprice + totalpizzaprice + totalwaterprice;
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("Toplam tutar: " + totalprice);
            #endregion


            Console.Read();
        }
    }
}
