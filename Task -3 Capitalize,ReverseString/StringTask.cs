using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Security.Cryptography.X509Certificates;

namespace exercises
{
    class StringTask
    {
        string name;
        string[] nameArray;
        string[] updatedNameArray;

        string revstring;
        char[] carry;

        public void display()
        {
            Console.WriteLine("Enter your full name:");
            name = Console.ReadLine();
            nameArray = name.Split(" ");
            updatedNameArray = new string[nameArray.Length];

            for (int j = 0; j < nameArray.Length; j++)
            {
                string firstName = nameArray[j];
                string firstIndexValue = firstName[0].ToString();
                string replaceWithCap = firstIndexValue.ToUpper();
                string remainingText = firstName.Substring(1).ToLower();

                updatedNameArray[j] = replaceWithCap + remainingText;
            }

            // Print the updated names
            Console.WriteLine("Updated Name: " + string.Join(" ", updatedNameArray));
        }
        public void revString()
        {
            Console.WriteLine("Enter the name:");
            name = Console.ReadLine();
            carry = name.ToCharArray();

            for (int i = carry.Length-1; i >= 0; i--)
            {
                revstring += carry[i];
            }
            Console.WriteLine($"The actual string is {name} and the reversed string {revstring}");
        }
    }
}
