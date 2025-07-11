using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders4_Loops
{  
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for

            int bacterium = 1;
            for (int i = 1; i <= 24; i++)
            {
                bacterium *= 2;
                Console.WriteLine(i + " Saat sonunda " + bacterium + " bakteri bulunur");
            }
            Console.Read();
            #endregion


        }
    }
}
