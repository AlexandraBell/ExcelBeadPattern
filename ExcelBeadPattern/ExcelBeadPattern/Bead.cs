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

            //Validate file path and return an error to the user if it doesn't exist.
            inputFileNameValidation(args);

            //Create objects before they're needed
            Image beadIm;
            //Once validated, make a local copy to preserve original file
            beadIm = Image.FromFile(args[0]);

            //Next we are going to want to parse the image and place it into the excel file
            imageParsing(beadIm);

            //I can use this to set the color of the cell
            //[RangeObject].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

            Workbook final = excelPopulation();
        }

        //Currently leaving this as taking the whole array, may change as I solidify design.
        /*
        * inputValidation will take user input file and make sure
        * 1) The file has a valid extension for an image
        * 2) The file can be opened
        */
        //TODO - Fill out
        private static void inputFileNameValidation(string[] args)

        {

            throw new NotImplementedException();
        }

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
