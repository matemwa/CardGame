using System;
using System.Collections.Generic;
using System.IO;

namespace CardGame
{
    public class Tasktwo
    {
        public void PerformTaskTwo()
        // Reads a file and generates a deck of cards.
        {   // task 2

            var deckTaskTwo = new SetDeck();
            List<int> rowsTwo = new List<int> { 0 };

            List<string> output = deckTaskTwo.GetDeck(rowsTwo);
            string outputJoined = string.Join(", ", output);
            File.WriteAllText(Path.Combine("Files", "2-output.txt"), outputJoined);
            Console.WriteLine("Task 2: Output was saved to: {0} \n", Path.Combine("Files", "2-output.txt"));
        }
    }
}

