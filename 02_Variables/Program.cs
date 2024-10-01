using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;

            //Console.WriteLine(number);



            //Console.WriteLine("***** Fiyat Listesi *****");

            //double applePrice, orangePrice, strawberryPrice, potato, tomato;

            //applePrice = 14.85;
            //orangePrice = 10.22;
            //strawberryPrice = 86.24;
            //potato = 8.45;
            //tomato  = 15.25;


            //Console.WriteLine("--- Elma Birim Fiyatı " + applePrice);
            //Console.WriteLine("--- Portakal Birim Fiyatı " + orangePrice);
            //Console.WriteLine("--- Çilek Birim Fiyatı " + strawberryPrice);
            //Console.WriteLine("--- Patates Birim Fiyatı " + potato);
            //Console.WriteLine("--- Domates Birim Fiyatı " + tomato);


            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 0.542; orangeGram = 0.234; strawberryGram = 1.224; potatoGram = 0.421;     tomatoGram = 2.000;

            //double appleTotalPrice = appleGram * applePrice;

            //Console.WriteLine("Elma için ödenecek tutar : " + appleTotalPrice + "TL");
            #endregion

            #region Char Değişkenler

            //char symbol = 'a';  // TEK TIRNAK CHAR


            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("**** Cemn Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı :");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı :");
            //passengerSurname = Console.ReadLine();
            ////Console.Write("Yolcu  :");
            ////passengerDistrict = Console.ReadLine();
            ////Console.Write("Yolcu Adı :");
            ////passengerCity = Console.ReadLine();
            ////Console.Write("Yolcu Adı :");
            ////passengerAge = Console.ReadLine();

            //Console.WriteLine(passengerName + " " + passengerSurname);
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " +  totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion



            Console.Read();
        }
    }
}
