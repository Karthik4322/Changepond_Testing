using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class Replace
    {
        string[] fruits = { "Banana", "Apple", "Guava" };
        string searchvalue;
        string option = "";
        string replacingfrom = "";
        string replaceWith = "";
        int indexvalue;
        int ivrv;

        public void chooseoption()
        {
            Console.WriteLine("Enter the option to be choosed:\n 1.search 2.replace");
            option = Console.ReadLine();
            switch (option)
            {
                case "search":
                    findData();
                    break;
                case "replace":
                    replaceData();
                    break;
                default:
                    Console.WriteLine("You haven't selected the option");
                    break;
            }
           
        }
        public void findData()
        {
            
            Console.WriteLine("Enter a fruit name to be searched");
            searchvalue = Console.ReadLine();
          
            for (int indexvalue = 0; indexvalue < fruits.Length; indexvalue++)
            {
                if(string.Compare(fruits[indexvalue], searchvalue, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    Console.WriteLine($"The fruit {searchvalue} is found at {indexvalue}");
                }              
            }
            

            //else
            //{
            //    Console.WriteLine($"The fruit {searchvalue} is not present in list");
            //}

        }
        public void replaceData()
        {
            foreach (string s in fruits) Console.WriteLine(s);
           
            Console.WriteLine("Enter the element wanted to be replaced from list");
            string replacingfrom = Console.ReadLine();


            for (int indexvalue = 0; indexvalue < fruits.Length; indexvalue++)
            {
                if (string.Compare(fruits[indexvalue], replacingfrom, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    Console.WriteLine($"The fruit {replacingfrom} is found at {indexvalue}");
                    ElementFound(indexvalue);
                    break;
                }
                
            }
        }
        public int ElementFound(int elementIndex)
        {

            Console.WriteLine("Enter the data to be replaced : ");
            replaceWith = Console.ReadLine();
            fruits[elementIndex] = replaceWith;
            Console.WriteLine("After the changes made on list :");
            foreach (string s in fruits) Console.WriteLine(s);
            return 0;
        }


    }
}
