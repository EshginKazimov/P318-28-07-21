using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 5, 6, 4, 3, 8, 9 };

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            #region Methods

            //PrintToConsole();
            //PrintToConsole();

            //Console.WriteLine("A = ");
            //int a = int.Parse(Console.ReadLine());
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("B = ");
            //int b = int.Parse(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //int result = Sum(a, b);
            //result++;
            //result *= 2;
            //Console.WriteLine(result);

            //string x = "16.5";
            //string y = "5b";

            //Console.WriteLine(x + y);

            //string result = Print("Ulvi");
            //Console.WriteLine($"{result} Ismayilov");

            //result = Print("Ozal");
            //Console.WriteLine($"{result} 29");

            #endregion

            #region Overload methods

            //int result = Multiply(7, 3, 1);
            //result++;
            //Console.WriteLine(result);

            //Console.WriteLine(Multiply(1, 2));

            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(1, 2, 3));
            //Console.WriteLine(Sum(1.0M, 2.5M));
            //Console.WriteLine(Sum(1, 2));

            #endregion

            #region Params

            //int[] arr = { 1, 5, 6, 7, 4, 3, 2 };
            //Print(arr);

            //Print(1, 2, 3);
            //Print(1, 2);
            //Print(1);
            //Print(1, 2, 3, 4, 5, 6, 7, 8);

            #endregion
        }

        #region Params

        //static void Print(int a, int b)
        //{
        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //}

        //static void Print(int a, int b, int c)
        //{
        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //    Console.WriteLine(c);
        //}

        //static void Print(params int[] arr)
        //{
        //    foreach (int item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //static void Print(int[] arr)
        //{
        //    foreach (int item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        #endregion

        #region Overload methods

        //Overload methods - parametrs count, parametrs types

        static decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }

        static double Sum(double a, double b)
        {
            return a - b;
        }

        static int Sum(int a, int b = 10, int c = 10)
        {
            return a + b + c;
        }

        static int Sum(int a, int b = 10)
        {
            //Console.WriteLine(a + b);
            int result = a + b;

            return result;
        }

        static int Multiply(int a = 1, int b = 7, int c = 8)
        {
            return a + b * c;
        }

        #endregion

        #region Methods

        static string Print(string name)
        {
            string result = $"{name} P316";
            //Console.WriteLine(result);

            return result;
        }

        static void PrintToConsole()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);
            Console.WriteLine($"Hello {name}");
        }

        #endregion
    }
}
