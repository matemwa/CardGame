using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CardGame
{
    public class Taskthree
    {
        public void PerformTaskThree()
        {
            string[] inputFile = File.ReadAllLines(Program.filePath);
            
            int inputFileLength = inputFile.Count();
            
            if (inputFileLength < 2)
            {
                Console.WriteLine("Task 3: Please choose at least 2 decks.\n");

            }

            else
            {
                var deckNew = new SetDeck();
                IEnumerable<int> RowsThreeSet = Enumerable.Range(0, inputFileLength);
                List<int> Decks = new List<int>();

                foreach (int row in RowsThreeSet)
                {
                    Decks.Add(row);
                }

                List<string> DeckCombined = deckNew.GetDeck(Decks);

                if (DeckCombined.Count < 10)
                {
                    Console.WriteLine("Task 3: The deck should consists of minimum 10 cards. \n Please choose the right deck.");
                }

                else
                {
                    Random random = new Random();
                    var output = new List<string>();
                    var RandomList = new List<int>();


                    for (int cardNum = 0; cardNum < 10; cardNum++)
                    {
                        var currentRandom = random.Next(0, DeckCombined.Count);

                        if (RandomList.Contains(currentRandom))
                        {
                            cardNum--;
                        }
                        else
                        {
                            RandomList.Add(currentRandom);
                        }
                    }

                    foreach (int num in RandomList)
                    {
                        output.Add(DeckCombined[num]);
                    }
                    string outputJoined = string.Join(", ", output);
                    File.WriteAllText(Path.Combine("Files", "3-output.txt"), outputJoined);
                    Console.WriteLine("Task 3: Output was saved to: {0} \n", Path.Combine("Files", "3-output.txt"));

                }
            }
        }
    }
}