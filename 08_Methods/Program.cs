using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods


            //void CustomerList()
            //{
            //    Console.WriteLine("Cem Yılmaz");
            //    Console.WriteLine("Cem Yılmaz");
            //    Console.WriteLine("Cem Yılmaz");
            //    Console.WriteLine("Cem Yılmaz");




            //}
            //CustomerList();



            #endregion

            #region Void Methods with Parameters

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}

            //#endregion

            //WriteMethod("Cem");



            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri" + name + " " + surname);
            //}

            //CustomerCard("cem", "yılmaz");

            #endregion

            #region Void Methods With Int Parameters

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1, 223, 54);
            #endregion

            #region Methods that return values

            //int Sum(int number1, int number2, int number3) {

            //    return number1 + number2 + number3;
            //}

            //int x = Sum(1, 25, 32);
            //Console.Write(x);


            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke" + countryName + " " + capital + " Bayrak Rengi" + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.WriteLine("Ülke adını giriniz : ");
            //x = Console.ReadLine();
            //Console.WriteLine("Başkent adını giriniz : ");
            //y = Console.ReadLine(); 
            //Console.WriteLine("Bayrak  rengini giriniz : ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));


            #endregion

            #region Methods That Return Int Values

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;

            //}

            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(5, 125));
            //Console.WriteLine(Sum(4326, 3));


            #endregion


            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3)/3;
                if (result >= 50)
                {
                    return student + " adlı öğrenci sınavı başarıyla geçti";
                }
                else
                {
                    return student + " adlı öğrenci sınavdan kaldı";
                }
            }

            Console.WriteLine(ExamResult("Ali", 5, 26, 22));
            Console.WriteLine(ExamResult("Cem", 51, 99, 99));

            Console.Read();

        }
    }
}
