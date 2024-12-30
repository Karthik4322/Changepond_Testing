using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
  class WordOccurence
    {
        string input;
        string[] arr;
        string searchwith;
        int Count = 0;
        public void wordOccurrenceIgnoreCase() {
            Console.WriteLine("Enter a sentence to find word occurrence: ");// She sells sea shells on the sea
            input = Console.ReadLine();
            arr = input.Split("s");
            Console.WriteLine(arr.Length);
        }
        public void wordOccurrenceStrictlyCase()
        {
            Console.WriteLine("Enter a sentence to find word occurrence: ");// She sells sea shells on the sea
            input = Console.ReadLine();
            Console.WriteLine("Enter a character to find repeatation: ");
            searchwith = Console.ReadLine();
            char checkValue = searchwith[0];
            char[] chrs = input.ToCharArray();
            for (int i = 0; i < chrs.Length; i++)
            {
                if (chrs[i] == checkValue)
                {
                    Count++;
                } 
            }
            Console.WriteLine($"The repeatation of word {searchwith} is : {Count}");
      
        }
    }
}
