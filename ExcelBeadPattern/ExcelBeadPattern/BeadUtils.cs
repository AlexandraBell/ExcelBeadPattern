using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelBeadPattern
{
    class BeadUtils
    {
        //User display strings
        public static string USER_DISP_WELCOME = "Please input a range of numbers separated by a space. Ex: 1 20";
        public static string USER_DISP_QUIT = "To exit the program please enter any of the following: Q, QUIT, EXIT, or hit the Enter key \n";
        public static string USER_DISP_ERROR = "ERROR: Please make sure that your input is correct. \n";
        public static string USER_DISP_ERROR_SPACES = "ERROR: Incorrect number of spaces. \n";
        public static string USER_DISP_ERROR_SPACES_TWO = "ERROR: Input cannot start or end with a space. \n";
        public static string USER_DISP_ERROR_MINUS = "ERROR: Prime numbers are not negative. \n";
        public static string USER_DISP_ERROR_ALPHA = "ERROR: Only numbers or an exit statement is allowed. \n";
        public static string USER_DISP_ERROR_NULL = "ERROR: No input detected. \n";
        public static string USER_DISP_PRIME_NUM_LIST = "\nHere is a list of prime numbers from the parameters you've specified:";
        public static string USER_DISP_COMMA = ", ";
        public static string USER_DISP_ENTER_VALID_INPUT = "Please enter in valid input.";
        public static string USER_DISP_AGAIN = "\nWould you like to generate more prime numbers?";

        //Internal checking strings
        public static string[] CHECK_EXIT_ARRAY_REGEX = { "Q", "QUIT", "EXIT" };
        public static string CHECK_NUMBERS_REGEX = @"[0-9]";
        public static string CHECK_SPACE_REGEX = @"\s";
        public static string CHECK_MINUS_REGEX = @"-";
        public static string CHECK_ALPHA_REGEX = @"[a-zA-Z]";

        public static string CHECK_SPACE = " ";
        //Values to split strings on
        public static char SPLIT_SPACE = ' ';

        //Numbers
        public static int ZERO = 0;
        public static int ONE = 1;
        public static int TWO = 2;
        public static int THREE = 3;
        public static int FOUR = 4;
        public static int FIVE = 5;
        public static int TEN = 10;
    }
}
