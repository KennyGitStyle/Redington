using System;
using System.IO;

namespace Calculator.Data
{
    public class Helper
    {
        //Helper function
        public static void FileOutput(double PA, double PB, string TypeOfCalculation, ProbabilityData cal)
        {
            string path = "Data.txt";
            // Create a file to write to.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"PA=: {PA} ;PB=: {PB} ;Method is=: {TypeOfCalculation} ;Result=: {cal.currentCount} ;Date of Calculation=: {cal.DateOfCalculation}");
            }
            cal.Error = null;
        }
    }
}