using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else

            //string capital, country;


            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi! ");
            //}


            #endregion

            #region switch case

            Console.Write("Lütfen Ay Girişi Yapınız: ");

            int monthNumber= int.Parse(Console.ReadLine());
            switch(monthNumber)
            {
                case 1:Console.Write("Ocak");break;
                case 2:Console.Write("Şubat");break;
                case 3:Console.Write("Mart");break;
                case 4:Console.Write("Nisan");break;
                case 5:Console.Write("Mayıs");break;
                case 6:Console.Write("Haziran");break;
                case 7:Console.Write("Temmuz");break;
                case 8:Console.Write("Ağustos");break;
                case 9:Console.Write("Eylül");break;
                case 10:Console.Write("Ekim");break;
                case 11:Console.Write("Kasım");break;
                case 12:Console.Write("Aralık");break;
                default: Console.Write("Hatalı Veri Girişi"); break;
            }

            #endregion
            Console.Read();

        }
    }
}
