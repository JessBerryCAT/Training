using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"C:\Users\JessB\Documents\Test App\TestJPEG.jpg";
            string destinationFile = @"C:\Users\JessB\Documents\Test App Arrival Point\TestJPEG.jpg";

            System.IO.File.Move(sourceFile, destinationFile);
        }
    }
}