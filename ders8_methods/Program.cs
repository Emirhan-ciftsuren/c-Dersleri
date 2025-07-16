using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders8_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void metodları
            //void isimler()
            //{
            //    Console.WriteLine("Ahmet");
            //    Console.WriteLine("Mehmet");
            //    Console.WriteLine("Ayşe");
            //    Console.WriteLine("Mahmut");

            //}

            //isimler();
            //isimler();

            #endregion

            #region geriye döndüren parametreli metodlar
             int MyMethod(int x, int y)
            {
                return x + y;
            }

          
            
                Console.WriteLine(MyMethod(5, 3));



            #endregion
            Console.Read();
        }
    }
}
