using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelBeadPattern
{
    public class UserInput
    {
        public static void stuff(string[] args)
        {
            //Need to modify to take an image then size
            bool quit = false;

            Console.WriteLine(BeadUtils.USER_DISP_WELCOME);
            Console.WriteLine(BeadUtils.USER_DISP_QUIT);

            String uInput = uInput = Console.ReadLine();
            while (!quit && !String.IsNullOrEmpty(uInput))
            {
                quit = inputQuit(uInput.ToString());
                if (!quit)
                {
                    uInput = dispAndValidUserInput(uInput);
                    if (!String.IsNullOrEmpty(uInput))
                    {
                        int[] primeRange = populateNumRange(uInput);
                        //Gen the excel sheet

                        //ask user for another
                        Console.WriteLine(BeadUtils.USER_DISP_AGAIN);
                    }

                    uInput = Console.ReadLine();
                }
            }
        }

        /*
        * dispAndGetUserInput - takes in a string input
        * This returns a valid string from the user that
        * can be used later on.
        * returns string of numbers
        */
        public static String dispAndValidUserInput(String input)
        {
            int[] numberRange = null;

            if (validateUserInput(input))
            {
                numberRange = populateNumRange(input);
            }
            else {
                Console.WriteLine(BeadUtils.USER_DISP_ENTER_VALID_INPUT);
                input = "";
            }

            return input;
        }

        /*
        * inputQuit - takes a string as a parameter
        * returns true if any of the exit strings are entered
        * returns false otherwise
        */
        public static bool inputQuit(String input)
        {
            //Could possibly refactor this into a different loop where you iterate through exit_array
            bool isQuit = false;
            if (!String.IsNullOrEmpty(input))
            {
                foreach (String s in BeadUtils.CHECK_EXIT_ARRAY_REGEX)
                {
                    //Case insensitive
                    if (String.Equals(input, s, StringComparison.OrdinalIgnoreCase))
                    {
                        isQuit = true;
                    }
                }

            }
            return isQuit;
        }

        /*
        * analyzeUserInput - takes a string as a parameter
        * returns true if the string only contains numbers
        * returns false otherwise
        */
        public static bool validateUserInput(String input)
        {
            bool isValidInput = false;
            //Let's use a regex to find if there are only numbers in the string
            if (!String.IsNullOrEmpty(input))
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(input, BeadUtils.CHECK_NUMBERS_REGEX))
                {
                    isValidInput = true;
                }
                if (System.Text.RegularExpressions.Regex.Matches(input, BeadUtils.CHECK_SPACE_REGEX).Count
                    != BeadUtils.ONE)
                {

                    Console.Write(BeadUtils.USER_DISP_ERROR_SPACES);
                    isValidInput = false;
                }
                else if (input.StartsWith(BeadUtils.CHECK_SPACE) || input.EndsWith(BeadUtils.CHECK_SPACE))
                {
                    Console.Write(BeadUtils.USER_DISP_ERROR_SPACES_TWO);
                    isValidInput = false;
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(input, BeadUtils.CHECK_MINUS_REGEX))
                {

                    Console.Write(BeadUtils.USER_DISP_ERROR_MINUS);
                    isValidInput = false;
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(input, BeadUtils.CHECK_ALPHA_REGEX))
                {
                    Console.Write(BeadUtils.USER_DISP_ERROR_ALPHA);
                    isValidInput = false;
                }
            }
            return isValidInput;

        }

        /*
        * dispOrderedPrimes - takes an ordered list of integers
        * This will display the ordered list of primes to the user.
        * returns nothing
        */
        public static void dispOrderedPrimes(List<int> orderedPrimeNums)
        {
            Console.WriteLine(BeadUtils.USER_DISP_PRIME_NUM_LIST);
            String dispPrimes = "";
            if (orderedPrimeNums.Count > 0)
            {
                orderedPrimeNums.ForEach(x =>
                {
                    dispPrimes += x.ToString() + BeadUtils.USER_DISP_COMMA;
                    if (orderedPrimeNums.IndexOf(x) != BeadUtils.ZERO
                    && orderedPrimeNums.IndexOf(x) != orderedPrimeNums.Count
                    && orderedPrimeNums.IndexOf(x) % BeadUtils.FOUR == BeadUtils.ZERO)
                    {
                        int index = orderedPrimeNums.IndexOf(x);
                        //newline for readability
                        dispPrimes += "\n";
                    }
                });
                dispPrimes = dispPrimes.Substring(BeadUtils.ZERO, dispPrimes.Length - BeadUtils.TWO);
            }
            Console.WriteLine(dispPrimes);
        }

        /*
         * populateNumRange - takes a string as a parameter
         * returns an ordered integer array
         * [0] - smallest value
         * [1] - largest value
         */
        public static int[] populateNumRange(string input)
        {
            //we know by this point that the string only has 1 space and both are valid numbers
            int[] workbookDimensions = new int[BeadUtils.TWO];
            
            String[] splitInput = input.Split(BeadUtils.SPLIT_SPACE);

            workbookDimensions[BeadUtils.ZERO] = int.Parse(splitInput[BeadUtils.ZERO]);
            workbookDimensions[BeadUtils.ONE] = int.Parse(splitInput[BeadUtils.ONE]);
            
            return workbookDimensions;
        }

        //Currently leaving this as taking the whole array, may change as I solidify design.
        /*
        * inputValidation will take user input file and make sure
        * 1) The file has a valid extension for an image
        * 2) The file can be opened
        */
        //TODO - Fill out
        public static bool inputFileNameValidation(string input)

        {

            throw new NotImplementedException();
        }
    }
}
