using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace ExcelBeadPattern
{
    class Bead
    {
        //This will be where we process the command line arguements
        static void Main(string[] args)
        {
            //I also wanted the user to be able to specify their grid size
            bool quit = false;
            bool isValidImage;

            Console.WriteLine(BeadUtils.USER_DISP_WELCOME);
            Console.WriteLine(BeadUtils.USER_DISP_QUIT);


            String uInput = Console.ReadLine();
            //Validate file path and return an error to the user if it doesn't exist.            
            isValidImage = UserInput.inputFileNameValidation(uInput);
            if(!isValidImage)
            {
                Console.WriteLine(BeadUtils.USER_DISP_RETRY_IMAGE);
            }
            //Create objects before they're needed
            Image beadIm;
            //Once validated, make a local copy to preserve original file
            beadIm = Image.FromFile(args[0]);

            Console.WriteLine(BeadUtils.USER_DISP_DIMENSIONS);
            //Next we are going to want to parse the image and place it into the excel file
            imageParsing(beadIm);

            //I can use this to set the color of the cell
            //[RangeObject].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

            Workbook final = excelPopulation();
        }

        /*
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
*/

        //This method is going to transform the image into the excel file
        //I'm still unsure if I want to store the information in array/map/object and 
        //then have another method input it into the excel doc.
        private static void imageParsing(Image beadIm)
        {
            throw new NotImplementedException();
        }

        //This will fill out the excel file and return a workbook
        private static Workbook excelPopulation()
        {
            Workbook returnPopWorkbook = null;
            
                                    
            return returnPopWorkbook;
        }

    }
}
