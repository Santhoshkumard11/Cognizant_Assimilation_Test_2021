using System;
using System.Security.Cryptography;
using BCrypt.Net;

namespace SanthoshDemos
{
    public class Program
    {

        static void PrintSpaces(int noOfSpaces)
        {
            for (int itr = 0; itr < noOfSpaces; itr++)
            {
                Console.Write(" ");
            }
        }

        static void PrintStars(int noOfStars)
        {

            string listOfStars = "************";

            Console.Write(listOfStars.Substring(0,noOfStars));
            
        }

        public static void Main(string[] args)
        {

            int noOfLines = Convert.ToInt32(Console.ReadLine());


            for (int itr = 1; itr <= noOfLines; itr++)
            {

                PrintSpaces(noOfLines - itr);

                PrintStars(itr);

                Console.WriteLine("");

            }

        }
    }  
}

/*
 input = 5
 Output:
      *
     **
    ***
   ****
  *****
  */
