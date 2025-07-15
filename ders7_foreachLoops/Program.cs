using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders7_foreachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach 1
            //string[] cities = { "İstanbul", "Ankara", "Mardin", "Bursa", "Şanlıurfa" };

            //foreach (string city in cities)
            //{
            //   Console.WriteLine(city);
            //}
            #endregion

            #region foreach 2

            //string word = "Emirhan";
            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region Örnek sınav sistemi uygylaması

            Console.Write("****** C# Eğitim Kampı Sınav Uygulaması******");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki Öğrenci Sayısını Kullanıcıdan alma

            Console.WriteLine("-----------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine();

            // Öğrenci isimlerini ve notlarını saklayacak dziler

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 1; i <= studentCount; i++)
            {
                Console.Write(i + ". öğrencinin ismini giriniz: ");
                studentNames[i - 1] = Console.ReadLine();
                double totalExamResult = 0;
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(studentNames[i - 1] + " isimli öğrencinin " + (j) + ". sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                }
                studentExamAvg[i - 1] = totalExamResult / 3;
                Console.WriteLine("------------------------------");
            }
            //öğrencilerin ortalaması ve geçip kalma durumları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(studentNames[i] + " adlı öğrencinin ortalaması: ");
                Console.WriteLine("------------------------------");
                Console.WriteLine(studentExamAvg[i]);
                Console.WriteLine("------------------------------");
               
                
                if (studentExamAvg[i] > 50)
                {

                    Console.WriteLine("*****Öğrenci geçti.*****");

                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {

                    Console.WriteLine("Öğrenci kaldı...");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            #endregion
            Console.Read();
        }
    }
}
