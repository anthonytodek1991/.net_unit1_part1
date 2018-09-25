using System;
using System.Collections;
namespace Lab_1_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputOne;
            string userInputTwo;


            Console.WriteLine("Instructions about the program");

            Console.WriteLine("Please Enter The First Number");
            userInputOne = Console.ReadLine();
            CheckValidationForUserInput(userInputOne);

            Console.WriteLine("Please Enter The Second Number");
            userInputTwo = Console.ReadLine();
            CheckValidationForUserInput(userInputTwo);

            bool userResponse = CompareUserSumsOfUserInputs(userInputOne, userInputTwo);
            Console.WriteLine(userResponse);
        }

        private static void CheckValidationForUserInput(string userInput)
        {
            if (String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Please enter valid value");
            }
            else if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Please enter value without spaces");
            }
            else if (userInput.Length > 3)
            {
                Console.WriteLine("Please enter value of 3 digits in length");
            }
        }

        //method to compare the sums of the users input
        private static bool CompareUserSumsOfUserInputs(string userInputOne, string userInputTwo)
        {
            if (userInputOne.Length == userInputTwo.Length)
            {
                int[] sums = CompareUser(userInputOne, userInputTwo);

                if (sums[0] == sums[1] && sums[0] == sums[2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private static int[] CompareUser(string userInputOne, string userInputTwo)
        {
            int[] sums = new int[userInputOne.Length];

            //loops through both of the user inputs and adds each index together 
            //Then adds it to the new array
            for (int i = 0; i < userInputOne.Length; i++)
            {
                int valueOne = (int)Char.GetNumericValue(userInputOne[i]);
                int valueTwo = (int)Char.GetNumericValue(userInputTwo[i]);
                sums[i] = valueOne + valueTwo;
            }
            return sums;
        }
    }
}
