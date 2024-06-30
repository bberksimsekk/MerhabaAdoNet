﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerhabaAdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            ////Veritabanı ile ilgili ekleme veri çekme silme güncelleme(CRUD) işlemleri için kullanılır.
            ////System.Data.SqlClient; Eklenmelidir.

            ////Bağlantı Nesnesi
            //SqlConnection baglanti = new SqlConnection();

            ////Bağlantı Yolu
            //baglanti.ConnectionString = @"Data Source=BETO\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=True";

            ////Komut Nesnesi
            //SqlCommand komut = new SqlCommand();
            //komut.Connection = baglanti;

            ////Komut Metni(Veritabanındaki kategori sayısı)
            //komut.CommandText = "SELECT COUNT(*) FROM Categories";

            ////Bağlantı Aç
            //baglanti.Open();

            ////Sorguyu Çalıştır
            //int sayi = Convert.ToInt32(komut.ExecuteScalar());
            ////Eğer sorgudan geriye sadece 1 hücrelik veri dönüyor ise ExecuteScalar kullanılır

            //Console.WriteLine("Kategori Sayısı = " + sayi);

            ////Bağlantıyı Kapat
            //baglanti.Close();

            #endregion

            #region Ürün Sayısını Yazdıralım

            //SqlConnection con = new SqlConnection(@"Data source=BETO\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");

            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = "SELECT COUNT(*) FROM Products";

            //con.Open();

            //int productCount = Convert.ToInt32(cmd.ExecuteScalar());
            //Console.WriteLine("Ürün Sayısı = " + productCount);

            //con.Close();

            #endregion

            #region Kategorileri Listeleyelim

            //SqlConnection con = new SqlConnection(@"Data source=BETO\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");

            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories";

            //con.Open();

            //SqlDataReader reader = cmd.ExecuteReader();
            ////Eğer sorgu tablo döndürüyor ise ExecuteReader kullanılır.

            ////reader.Read() => okunmamış satır var ise true döndürür.
            //while (reader.Read())
            //{
            //    int ID = reader.GetInt32(0);
            //    string isim = reader.GetString(1);
            //    string aciklama = reader.GetString(2);
            //    Console.WriteLine($"{ID}) {isim}\n {aciklama}\n");
            //}

            //con.Close();

            #endregion

            #region Kategori Ekleme

            Console.WriteLine("Kategori Bilgilerini Giriniz");
            Console.Write("Isim = ");
            string isim = Console.ReadLine();
            Console.Write("Açıklama = ");
            string aciklama = Console.ReadLine();

            SqlConnection con = new SqlConnection(@"Data source=BETO\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Categories(CategoryName, Description) VALUES('" + isim + "','" + aciklama + "')";

            con.Open();
            cmd.ExecuteNonQuery();
            //Sorgudan geriye veri dömüyor ise ExecuteNonQuery kullanılır.
            con.Close();

            #endregion
        }
    }
}
