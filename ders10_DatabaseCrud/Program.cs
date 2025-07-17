using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud dört temel veri tabanı işleminin kısaltmasıdır: Create - Read - Update - Delete
            Console.WriteLine("***** Menü Sipariş işlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediiğniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (categoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Kategori başarılı bir şekilde eklendi");
            #endregion

            #region Ürün Ekleme İşlemi
            string productName;
            decimal productPrice;
            //bool productStatus;

            Console.Write("Ürün adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data source=(localdb)\\MSSQLLocalDB;initial catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProdactStatus) values (@productName,@productPrice,@productStatus)", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus",true);
            command.ExecuteNonQuery();
            connection.Close();
            Console.Write("Ürün eklemesi başarılı!");

            #endregion
        }
    }
}
