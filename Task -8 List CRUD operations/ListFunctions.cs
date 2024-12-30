using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Net.Quic;

namespace Arrayproj
{
    class ListFunctions
    {

        List<string> fruits = new List<string>(){ "Apple", "Banana", "Mango", "Orange", "Grapes" };

        string newItem;
        public void ListFunc() {

            List<int> numbers = new List<int>() { 2, 40, 10, 15, 100, 74 };
            List<int> newnumbers = new List<int>() { 5, 2, 3 };

            //numbers.Add(11);
            numbers.Insert(2, 55);
            //numbers.InsertRange(3, newnumbers);
            //numbers.AddRange(newnumbers);
            //numbers.Sort();
            //numbers.Reverse();
            //numbers.Remove(40);
            numbers.RemoveAt(2);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }


        public void chooseoption()
        {
            while (true)
            {
                Console.WriteLine("Enter the option to be choosed:\n1. Display fruit \n2. Add Fruit \n3. Update Fruit \n4. Delete Fruit \n5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        displayfruit();
                        break;
                    case 2:
                        addfruit();
                        break;
                    case 3:
                        updatefruit();
                        break;
                    case 4:
                        deletefruit();
                        break;
                    case 5:
                        goto quit;
                    default:
                        Console.WriteLine("You haven't selected the given option");
                        break;
                }
            }
                    quit:;
        }

        public void displayfruit()
        {
            foreach (string arr in fruits)
            {
                Console.WriteLine(arr);
            }

        }

        public void addfruit()
        {
            Console.Write("Enter a fruit name to add : ");
            newItem = Console.ReadLine();
            ComparewithExisting();

        }

        public void updatefruit()
        {
            foreach (string s in fruits) Console.WriteLine(s);

            Console.WriteLine("Enter the element wanted to be get updated from list");
            string replacingfrom = Console.ReadLine();


            for (int indexvalue = 0; indexvalue < fruits.Count; indexvalue++)
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

            Console.Write("Enter the updating fruit name : ");
            string replaceWith = Console.ReadLine();

            for (int indexvalue = 0; indexvalue < fruits.Count; indexvalue++)
            {
                if (fruits[indexvalue].Equals(replaceWith,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("The element is already exists not necessary to update with same value");
                    break;
                }
                else
                {
                    fruits[elementIndex] = replaceWith;
                    Console.WriteLine("After the changes made on list :");
                    foreach (string s in fruits) Console.WriteLine(s);
                    break;
                }
               
            }

            return 0;
        }

        public void deletefruit()
        {

            foreach (string s in fruits) Console.WriteLine(s);

            Console.WriteLine("Enter a element to be get deleted");
            string deletingfrom = Console.ReadLine();
            bool isAvailable = false;
           
                for (int indexvalue = 0; indexvalue < fruits.Count; indexvalue++)
                {
                    if (string.Compare(fruits[indexvalue], deletingfrom, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        // Console.WriteLine($"The fruit {deletingfrom} is found at {indexvalue}");
                        // DeleteElementFound(indexvalue);
                        fruits.RemoveAt(indexvalue);
                        Console.WriteLine($"The fruit {deletingfrom} is deleted ");
                        Console.WriteLine("After the changes made on list :");
                        foreach (string s in fruits) Console.WriteLine(s);
                    isAvailable = true;
                    }

                }
            
            if(isAvailable==false)
            {
                Console.WriteLine($"The {deletingfrom} item is not present in list to delete");
            }
        }

        public void ComparewithExisting() { 

            for(int indexvalue = 0; indexvalue < fruits.Count; indexvalue++) {
             
            if (fruits[indexvalue].Equals(newItem,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"The fruit {newItem} is found at {indexvalue}");
                    Console.WriteLine($"You can't add this {newItem} again");
                    break;
                }
                else
                {
                    fruits.Add(newItem);
                    Console.WriteLine($"The {newItem} added successfully ");
                    Console.WriteLine("After the changes made on list : ");
                    displayfruit();
                    break;
                }

            }
        }


}
    }



