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
            //objects needed
            Image beadIm;

            //Validate file path and return an error to the user if it doesn't exist.
            inputValidation(args);

            //Once validated, make a local copy to preserve original file
            beadIm = Image.FromFile(args[0]);


        }

        //Currently leaving this as taking the whole array, may change as I solidify design.
        /*
        * inputValidation will take user input file and make sure
        * 1) The file has a valid extension for an image
        * 2) The file can be opened
        */
        //TODO - Fill out
        private static void inputValidation(string[] args)
        {

            throw new NotImplementedException();
        }
    }
}
