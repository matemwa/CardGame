using System;
using System.Diagnostics;
using System.IO;


namespace CardGame
{
    class Program
    {

        public static string filePath = Path.Combine("Files", "1-input.txt");

        static void Main(string[] args)
        {
            while (true)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                Console.WriteLine("Please enter which task you want to proceed? " +
                    "\n\t Choose: '1', '2', '3','4', '5', 'all'. " +
                    "\n Task '1': Copy input to output file." +
                    "\n Task '2': Unpack decks provided by the input to output file." +
                    "\n Task '3': Combine decks and pick 10 cards at random." +
                    "\n Task '4': Play a simple card game." +
                    "\n Task '5': Play an advanced card game." +
                    "\n All proceeds all tasks from 1 to 5.");

                string input = Console.ReadLine().ToLower().Trim();
                bool validation = false;
                if ((input != "1")
                   && (input != "2")
                   && (input != "3")
                   && (input != "4")
                   && (input != "5")
                   && (input != "all"))
                {
                    validation = true;
                }

                while (validation)
                {
                    Console.WriteLine("Wrong input\n" +
                            "Please enter 1, 2, 3, 4, 5 or 'all'.");
                    input = Console.ReadLine().ToLower().Trim();

                    if (input == "1" ||
                        input == "2" ||
                        input == "3" ||
                        input == "4" ||
                        input == "5" ||
                        input == "all")
                    {
                        validation = false;
                    }
                }

                switch (input)
                {
                    case "1":
                        Taskone taskOne = new Taskone();
                        taskOne.PerformTaskOne();
                        break;


                    case "2":
                        Tasktwo taskTwo = new Tasktwo();
                        taskTwo.PerformTaskTwo();
                        break;

                    case "3":
                        Taskthree taskThree = new Taskthree();
                        taskThree.PerformTaskThree();
                        break;

                    case "4":
                        Taskfour taskFour = new Taskfour();
                        taskFour.PerformTaskFour();
                        break;

                    case "5":
                        // Taskfive taskFive = new Taskfive();
                        // taskFive.PerformTaskFive();
                        Console.WriteLine("Under development.");
                        break;

                    case "all":
                        Taskone taskOneAll = new Taskone();
                        taskOneAll.PerformTaskOne();
                        Tasktwo taskTwoAll = new Tasktwo();
                        taskTwoAll.PerformTaskTwo();
                        Taskthree taskThreeAll = new Taskthree();
                        taskThreeAll.PerformTaskThree();
                        Taskfour taskFourAll = new Taskfour();
                        taskFourAll.PerformTaskFour();
                        // Taskfive taskFiveAll = new Taskfive();
                        // taskFiveAll.PerformTaskFive();
                        break;

                    default:
                        Console.WriteLine("Invalid input!");
                        break;


                }

                stopWatch.Stop();
                long duration = stopWatch.ElapsedMilliseconds;
                Console.WriteLine("\nElapsed time in miliseconds: " + duration);

            }
        }
    }
}
