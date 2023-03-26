using System;
using System.Linq;

namespace mentorship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LearningArray();
            //LearningCsharp(5);
            //Console.WriteLine(LearningCsharp(5));
            Console.WriteLine(SumArray()); 
        }

        public static void LearningArray()
        {
            string[] StudentNames = { "ade", "ayo", "ola", "abayo" };

            Console.WriteLine("search for a student name");
            string SearchInput = Console.ReadLine();

            bool result = StudentNames.Contains(SearchInput.ToLower());

            if (result == true)
            {
                Console.WriteLine($"The student {SearchInput} is present");
            }
            else
            {
                Console.WriteLine($"The student {SearchInput} is not present ");
            }
        }

        public static int LearningCsharp(int numb1)
        {
            return numb1 * 2;

        }

        public static int SumArray()
        {
            int[] ArrayNumber = { 30, 50, 90 };

            int sum =0;

           // foreach (int values in ArrayNumber)
            for (int i = 0; i<ArrayNumber.Length; i++)
            {

                sum = ArrayNumber[i] + sum;
              
            }  

           return sum;

        }


    }
}
