using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    class Program
    {
        static void Main(string[] args)
        {

            //crud --> Create - Read - Update - Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("----------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = YUSUF\\SQLEXPRESS; initial Catalog = EgitimKampiDb; integrated security = true;");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values(@p1)", connection);

            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); //koşulsuz bir şekilde sorguyu çalıştır

            //connection.Close();

            //Console.Write("Kategori Başarıyla Eklendi");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = YUSUF\\SQLEXPRESS; initial Catalog = EgitimKampiDb; integrated security = true;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values(@productName,@productPrice,@productStatus)", connection);


            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery(); // Değişiklikleri kaydet ve bunu db ye yansıt
            //connection.Close();

            //Console.Write("Ürün başarıyla eklendi");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source = YUSUF\\SQLEXPRESS; initial Catalog = EgitimKampiDb; integrated security = true;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}


            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silmek İstediğiniz Ürün Id : ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = YUSUF\\SQLEXPRESS; initial Catalog = EgitimKampiDb; integrated security = true;");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün başarıyla silindi");

            #endregion

            #region Ürün Güncelleme İşlemi


            //Console.Write("Güncellemek İstediğiniz Ürün Id : ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Yeni Ürün Adı : ");
            //string productName = Console.ReadLine();

            //Console.Write("Yeni Ürün Fiyatı : ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = YUSUF\\SQLEXPRESS; initial Catalog = EgitimKampiDb; integrated security = true;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName = @productName, ProductPrice = @productPrice Where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün başarıyla güncellendi");

            #endregion

            Console.Read();

        }
    }
}
