using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** ÜRÜN - KATEGORİ BİLGİ SİSTEMİ ****");
            Console.WriteLine(); 
            Console.WriteLine();


            string tableNumber = "";


            Console.WriteLine("-------------------------");
            Console.WriteLine("1 - KATEGORİLER");
            Console.WriteLine("2 - ÜRÜNLER");
            Console.WriteLine("3 - SİPARİŞLER");
            Console.WriteLine("4 - ÇIKIŞ");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz : ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------");



            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5LU8384;Initial Catalog=EgitimKampiDb;Integrated Security=True;");


            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From TblCategory", conn);
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
