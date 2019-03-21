using System;
using System.Collections.Generic;
using System.IO;

namespace CardGame
{
    public class Taskfour
    {
        public void PerformTaskFour()
        {
            var deckNew = new SetDeck();
            List<int> rowsFour = new List<int> { 0 };
            List<string> deck = deckNew.GetDeck(rowsFour);
            string deckTaskFourJoined = string.Join(", ", deck);
            
            Random random = new Random();
            List<string> GameResults = new List<string>();

            // Pick 2 random unique cards
            
            for (int gameNumber = 0; gameNumber < 10; gameNumber++)
            {
                int firstCardNum = random.Next(deck.Count);
                int secondCardNum = random.Next(deck.Count);

                while (secondCardNum == firstCardNum)
                    secondCardNum = random.Next(deck.Count);

                string firstCard = deck[firstCardNum];
                string secondCard = deck[secondCardNum];
                string handValue = firstCard + ", " + secondCard + ", ";
                
                if (firstCard.StartsWith("H"))
                {
                    if (secondCard.StartsWith("H") || secondCard.StartsWith("D") || secondCard.StartsWith("S"))
                    {
                        handValue = handValue + "Win";
                    }

                    else
                    {
                        handValue = handValue + "Loss";
                    }
                    GameResults.Add(handValue);
                }

                else if (firstCard.StartsWith("C"))
                {
                    if (secondCard.StartsWith("H"))
                    {
                        handValue = handValue + "Tie";
                    }

                    else
                    {
                        handValue = handValue + "Loss";
                    }
                    GameResults.Add(handValue);
                }

                else if (firstCard.StartsWith("D") || firstCard.StartsWith("S"))
                {
                    if (secondCard.StartsWith("D") || secondCard.StartsWith("S"))
                    {
                        handValue = handValue + "Tie";
                    }

                    else
                    {
                        if (secondCard.StartsWith("H"))
                        {
                            handValue = handValue + "Win";
                        }
                        else
                        {
                            handValue = handValue + "Loss";
                        }
                    }
                    GameResults.Add(handValue);

                }
            }
                         
            File.WriteAllLines(Path.Combine("Files", "4-output.txt"), GameResults);
            Console.WriteLine("Task 4: Output was saved to: {0} \n", Path.Combine("Files", "4-output.txt"));

        }
    }
}
