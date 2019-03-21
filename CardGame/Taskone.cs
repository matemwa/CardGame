using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CardGame
{
    public class Taskone
    {
        public void PerformTaskOne()
        //Task one that reads file and copies it to the output
        {
            string[] inputFile = File.ReadAllLines(Program.filePath);
            File.WriteAllLines(Path.Combine("Files", "1-output.txt"), inputFile);
            Console.WriteLine("Task 1: File 1-input copied to {0} \n", Path.Combine("Files", "1-output.txt"));
        }
    }
}
