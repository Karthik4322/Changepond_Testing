using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arrayproj
{
     class ArrayFunction
    {
        
        int Isearchelement;
        int[] numbers = { 10, 200, 6, 4, 51 };
        string[] fruits = { "Apple", "Banana", "Mango", "Orange", "Grapes" };
        string Ssearchelement = "";
        string firstvalue;
        public void showArrayFunction()
        {

            int[] newNumbers = new int[5];

            Console.WriteLine(Array.IndexOf(numbers, 6));
            Console.WriteLine(Array.BinarySearch(numbers, 6));
            numbers.CopyTo(newNumbers, 0);


            foreach (int nn in newNumbers)
                Console.WriteLine(nn);


            Array.Resize(ref newNumbers, 7);
            newNumbers[5] = 15;
            newNumbers[6] = 13;


            foreach (int nn in newNumbers)
                Console.WriteLine(nn);

            Array.Clear(newNumbers); // To delete all elements from that array
            Array.Reverse(numbers);  // To reverse the numbers in the array
            Console.WriteLine("===================================================");
            foreach (int num in numbers)
                Console.WriteLine(num);
        }

            public void FruitFound()
            {
                Console.WriteLine("Enter a fruit wanted to be searched: ");
                string ssearchelement = Console.ReadLine();
                ssearchelement = TitleCase(ssearchelement);

                if (Array.Exists(fruits, element => element.Equals(ssearchelement, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"The {ssearchelement} element is present in the array.");
                }
                else
                {
                    Console.WriteLine($"The {ssearchelement} element is not present in the array.");
                }
            chooseoption();
            }

            public string TitleCase(string input)
            {
                if (string.IsNullOrEmpty(input))
                {
                    return input; // if there is empty space character
                }

                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;// predefined function to convert string into Titlecase using TextInfo
                return textInfo.ToTitleCase(input.ToLower());
            }
        
            public void chooseoption()
            {
            Console.WriteLine("Enter the option to be choosed:\n 1.Display fruit 2. Find Fruit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    displayfruit();
                    break;
                case 2:
                    FruitFound();
                    break;
                default:
                    Console.WriteLine("You haven't selected the option");
                    break;
            }

        }
        public void displayfruit()
        {
            foreach (string arr in fruits) { 
            Console.WriteLine(arr);
        }
            chooseoption();
        }
      

    }
}
