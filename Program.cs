using System;
using System.Collections.Generic;

namespace ExamenNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome palindrome = new Palindrome();
            ReImplement reImplement = new ReImplement();
            //Console.Clear();
            DateTime dat = DateTime.Now;
            Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);
            Console.Write("\nPlease introduce the string to check if is a palindrome and Enter key to continue... ");
            string inputString = Console.ReadLine();

            if (palindrome.checkWord(inputString.ToLower()))
            {
                Console.WriteLine("\nYour word IS a Palindrome");
            }
            else
            {
                Console.WriteLine("\nYour word IS NOT a Palindrome");
            }
            //Execute the Reimplement String
            Console.Write("\nPlease Insert your Delimiter and Enter key to continue... ");
            string delimiterFromUser = Console.ReadLine();
            char[] charArr = delimiterFromUser.ToCharArray();

            if (charArr.Length > 1)
            {
                Console.WriteLine("\nThere is an error in the separator, please check");
            }
            else
            {
                string[] traditionalSplit = reImplement.Traditional(inputString, charArr[0]);
                for (int i = 0; i < traditionalSplit.Length; i++)
                {
                    Console.WriteLine("\nTraditional Split");            
                    Console.WriteLine(traditionalSplit[i]);
                }

                reImplement.SplitReimplemented(inputString, charArr[0]);
               

            }
        }
    }
}
