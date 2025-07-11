using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dik üçgen
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Baklava dilimi
            int n = 5;
            for (int i = 1; i <= n; i++) // boşluk ve yıldızları tekrarlıyor
            {
                for (int j = n-i; j > 0; j--)// yan yana boşluk
                {
                    Console.Write(' ');
                }
                for (int k = 1; k <= 2 * i - 1; k++)// yan yana yıldız
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
                
            }
            for(int i=n-1;i>=1;i--)//ters üçgen
            {
                for (int j = n-i; j > 0; j--)//boşluk
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2*i-1; k++)//yıldız
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
            #endregion
        }
    }
}
