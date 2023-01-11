using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Solution_C_Sharp
{
    internal class Solution
    {
        public static int Summary() {

            string?input;
            int result = 0;
            Console.WriteLine("Input Number Integer: ");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++) {
                int temp = Convert.ToInt32(input[i]) - '0';
                result += temp;
            }
            return result;
        }


        public static int Digit() {

            int result =0;
            string? input;
            Console.WriteLine("Input Number Integer: ");
            input = Console.ReadLine();

            foreach (char x in input) {
                result++;
            }
            return result;
        }

        public static void reverseCharracter ()
        {
            string input;
            Console.WriteLine("Input Number Integer: ");
            input = Console.ReadLine();

            for (int i = input.Length-1; i >= 0;  i--)
            {
                Console.Write($"{input[i]} ");
            }

        }

        public static void Highest() {  
            int highest = 0;
            int input = 0;

            do {
                Console.Write("Enter Integer [ Type 0 for exit ]: ");
                input = Convert.ToInt32( Console.ReadLine());
                if (input>highest) highest = input;
            } while (input != 0);

            Console.Write("Angka terbesar: "+highest);

        }

        public static void divisionNumber() {
            int input = 0;

            Console.Write("Enter numbers : ");
            input = Convert.ToInt32(Console.ReadLine());

            Console.Write("Angka Pembagi: ");
            for (int i = 1; i <= input/2; i++)
            {
                if (input % i == 0) {
                    Console.Write($"{i} ");
                }
            }
            }
        public static void PrimeNumber() {
            int input = 0;
            Console.Write("Enter limit numbers : ");
            input = Convert.ToInt32(Console.ReadLine());

            Console.Write("Prime Number: ");

            for (int i=2; i<=input; i++) {
                int faktor = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) {
                        faktor += 1;
                    }
                }
                if (faktor == 2) {
                    Console.Write($"{i} " );
                }
            }
        }

        public static void replaceMiddle() {
            string x = "fahhfd  banfan  forfr";

            string[] words = x.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                for (int j = 0; j < word.Length; j++)
                {
                if (j == 0 || j == word.Length - 1)
                {
                    Console.Write($"{word[i]}");
                }
                else Console.Write("*");
                }
                Console.Write(" ");
            }

        }

        public static void SecondHigh() {
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter {i+1}. number: ");
                arr[i] = Convert.ToInt32( Console.ReadLine());
            }

           int[] disticntArr = arr.Distinct().ToArray();

            Array.Sort(disticntArr);            
            Console.Write($"Second Greatest {disticntArr[(disticntArr.Length-2)]}");            
        
        }

        public static Boolean CheckKurawal() {

            string input = "{{{}}";
            int bracket = 0;
            int bracket2 = 0;     
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('{')){
                    bracket++;
                }
                else
                {
                    bracket2++;
                }
            }
            if (bracket == bracket2) 
                return true;
            else 
                return false;
        }

        public static void JumlahString() {

            string inputString;
            string findString;
            Console.Write("Enter String: ");
            inputString = "111222112221111";
            Console.Write("Find String: ");
            findString = "11";
            int count = 0;
            int index = inputString.IndexOf(findString);

            //Console.WriteLine("Length: "+findString.Length);
            //Console.WriteLine("index: "+index);
            //Console.WriteLine(index+findString.Length);

            while (index != -1)
            {
                index = inputString.IndexOf(findString, index + findString.Length);
                count++;
            }
            Console.WriteLine($"Total kata yang muncul: {count} dari text: {inputString}");


        }

    }
}
