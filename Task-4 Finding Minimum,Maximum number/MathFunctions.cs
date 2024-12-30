using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class MathFunctions
    {
        int a = 34, b = 45;
        double c = 45.4;
        int d = -56;
        int p = 3;
        int p1 = 2;
        int s = 4;
        public void operations()
        {
            Console.WriteLine($"The min value of {a} and {b} is {Math.Min(a, b)}");
            Console.WriteLine($"The max value of {a} and {b} is {Math.Max(a, b)}");
            Console.WriteLine($"The floor value of {c} is {Math.Floor(c)}");
            Console.WriteLine($"The Ceiling value of {c} is {Math.Ceiling(c)}");
            Console.WriteLine($"The Round value of {c} is {Math.Round(c)}");
            Console.WriteLine($"The Absolute value of {d} is {Math.Abs(d)}");
            Console.WriteLine($"The power value of {p} square of {p1}  is {Math.Pow(p, p1)}");
            Console.WriteLine($"The square root of {s} is {Math.Sqrt(s)}");
        }

        public void findMinimumNumber()
        {


            int[] arr = { 5, 3, 8, 1, 2 };

            for (int i = 0; i < arr.Length - 1; i++) 
            {
                for (int j = 0; j < arr.Length - i - 1; j++) 
                {
                    if (arr[j] > arr[j + 1]) 
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("The minimum value: " + arr[0]);
            Console.WriteLine("Find the minimum value using MathFunction" + Math.Min(arr[0], arr[1]));
            Console.WriteLine("Find the maximum value using MathFunction" + Math.Max(arr[0], arr[1]));


        }
    }
}
