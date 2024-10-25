using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop

            //int[] numbers = new int[] { 1, 56, 43, 12, 54, 12, 554 };

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = new int[] { 1, 56, 43, 12, 54, 12, 554 };

            //int total = 0;

            //foreach (var number in numbers)
            //{
            //    total 
            //        += number;
            //}

            //Console.WriteLine(total);   


            //List<int> numbers = new List<int>()
            //{
            //    1,2,65,2,3,5,76,1,46,568,23446
            //};

            //foreach (int i in numbers) { Console.WriteLine(i); }

            //List<int> numbers = new List<int>()
            //{
            //    1,2,65,2,3,5,76,1,46,568,23446
            //};

            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //List<int> numbers = new List<int>()
            //{
            //    1,2,65,2,3,5,76,1,46,568,23446
            //};

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}

            //List<int> numbers = new List<int>()
            //{
            //    1,2,54,6,2,1
            //};

            //Console.WriteLine(numbers.);
            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("******* C# Sınav ********");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------");

            // Sınıftaki öğrenci sayısını alma 
            Console.Write("Sınıfınızda Kaç Öğrenci Var : ");
            int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAverage = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine("-------------");
                studentExamAverage[i] = totalExamResult / 3;

            }

            // ÖĞRENCİLERİN ORTALAMASI VE GEÇİP KALMA DURUMLARI

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentExamAverage[i]}");

                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("------------------");
            }
            #endregion


            Console.Read();
        }
    }
}
