using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region IF

            //Console.WriteLine("Şifreyi Giriniz");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Log in is succesful");

            //}
            //else
            //{
            //    Console.WriteLine("Password  is wrong");
            //}



            //string capital, country;
            //Console.Write("Write The Capital Name : ");
            //capital = Console.ReadLine();

            //Console.Write("Write The Country Name : ");
            //country = Console.ReadLine();   

            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Data is verified");

            //}
            //else
            //{
            //    Console.Write("Wrong data");
            //}

            //int number;

            //Console.Write("Write number : ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5) {
            //    Console.WriteLine("Number is correct");
            //}
            //else
            //{

            //    Console.WriteLine("number is wrong");
            //}

            //int exam1, exam2, exam3, average;
            //string result;

            //Console.WriteLine("Exam-1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Exam-2 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Exam-3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Exam's average is : " + average);

            //if (average > 0 & average <= 50)
            //{
            //    Console.WriteLine("Average is very bad");

            //}
            //if(average > 50 & average <= 70) {

            //     Console.WriteLine("Average is average :D ");
            //}
            //if(average > 70 & average <= 84 ) {
            //     Console.WriteLine("Average is good :D ");
            //}
            //if (average > 84)
            //{
            //    Console.WriteLine("Average is awesome");
            //}

            //string city;
            //Console.WriteLine("Please enter the city : ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("City is available");
            //}
            //else
            //{
            //    Console.WriteLine("City isn't available");
            //}

            //Console.Write("Enter the username");
            //string userName = Console.ReadLine();
            //if (userName != "admin")
            //{
            //    Console.WriteLine("Wrong Username");
            //}
            //else
            //{
            //    Console.WriteLine("Welcome");
            //}
            #endregion

            #region Mod Transactions

            //int number = 26;
            //int result = number % 5;

            //Console.WriteLine(result);


            Console.WriteLine("Please enter the first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 % number2;

            Console.WriteLine(result);

            #endregion

            Console.Read();

        }
    }
}
