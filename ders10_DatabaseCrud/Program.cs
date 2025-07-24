using System;
using System.Collections.Generic;
using System.Data;
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
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=(localdb)\\MSSQLLocalDB;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProdactStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus",true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılı!");

            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data source=(localdb)\\MSSQLLocalDB;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{

            //    //   Console.WriteLine("++"+row.ItemArray[0].ToString() + " ++ " + row.ItemArray[1].ToString() + " ++ " + row.ItemArray[2].ToString() + " ++ " + row.ItemArray[3].ToString() + " ++ "); 
            //    // iç dögüyü pasivize edip yukarı taraf kullanılabilir

            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " - ");
            //    }

            //    Console.WriteLine();
            //}
            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silinecek Ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;initial catalog=EgitimKampiDb;integrated security=true ");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where productId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //int response = command.ExecuteNonQuery();
            //connection.Close();
            //if (response>0 )
            //{
            //    Console.WriteLine("Silme işlemi yapıldı! ");

            //}
            //else
            //{
            //    Console.WriteLine("Silme işlemi yapılamadı! ");

            //}

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek ürünün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;initial catalog=EgitimKampiDb;integrated security=true ");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set productName=@a,productPrice=@b where productId=@c",connection);
            
            //command.Parameters.AddWithValue("@a", productName);
            //command.Parameters.AddWithValue("@b", productPrice);
            //command.Parameters.AddWithValue("@c", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Güncelleme Başarılı!");

            #endregion
        }
    }
}
