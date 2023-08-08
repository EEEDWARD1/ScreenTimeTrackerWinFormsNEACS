using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenTimeTracker.Models
{
    internal class DataHandler
    {
        private static string filePath = @"C:\Users\aurel\OneDrive\CS NEA Coursework\ScreenTimeTracker\ScreenTimeTracker\Models\data.csv";

        // method checks for CSVFileExistance and if it can't detect it, it proceeds to create one
        public static void CheckCSVFileExists()
        {

        }

        // This method writes a line to a CSV file with the app name, time spent and date
        public static void WriteToCSV(string _AppName, TimeSpan _TimeSpent)
        {
            
            using (StreamWriter writer = new StreamWriter(filePath, true)) // Create a stream writer to append text to the file path
            {
                string line = $"{_AppName},{_TimeSpent},{DateTime.Now.ToString("yyyy-MM-dd")}"; // Format the line with commas as separators
                writer.WriteLine(line); // Write the line to the file
            }
        }

        // method to read CSV file
        public static void ReadFromCSVFile()
        {

        }
    }
}