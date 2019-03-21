using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Taskfive
    {
        public void PerformTaskFive()
        {
            // THIS IS UNNECESSARY
            //Console.WriteLine("Please enter power of the game: " +
            //    "weak/normal/strong");
            //string power = Console.ReadLine().ToLower().Trim();
            //bool validationPower = false;
            //if (power != "weak" && power != "normal" && power != "strong")
            //{
            //    validationPower = true;
            //}

            //while (validationPower)
            //{
            //    Console.WriteLine("Wrong input\n" +
            //            "Please enter power of the game: " +
            //            "weak/normal/strong");
            //    power = Console.ReadLine().ToLower().Trim();

            //    if (power == "weak" || power == "normal" || power == "strong")
            //    {
            //        validationPower = false;
            //    }
            //}




            //Console.WriteLine("Please enter bet for the game:" +
            //    "easy/typical/hard");
            //string bet = Console.ReadLine().ToLower();
            //bool validationBet = false;
            //if (bet != "easy" && bet != "typical" && bet != "hard")
            //{
            //    validationBet = true;
            //}

            //while (validationBet)
            //{
            //    Console.WriteLine("Wrong input\n" +
            //            "Please enter power of the game: " +
            //            "easy/typical/hard");
            //    bet = Console.ReadLine().ToLower();

            //    if (bet == "easy" || bet == "typical" || bet == "hard")
            //    {
            //        validationBet = false;
            //    }
            //}
            string[] powers = new string[] { "weak", "normal", "strong" };
            string[] bets = new string[] { "easy", "typical", "hard" };
            int[] deckValue = new int[] { 0, 3, 0 }; // no matter what bet, the neutral amunt of cards is equal to 3.
            foreach (string power in powers)
                switch (power)
                {
                    case "weak":
                        deckValue[0] += 3;
                        foreach (string bet in bets)
                        {
                            switch (bet)
                            {
                                case "easy":
                                    deckValue[0] += 2;
                                    deckValue[2] += 4;
                                    // new class that returns a value and writes it to output same every case
                                    break;
                                case "typical":
                                    deckValue[0] += 0;
                                    deckValue[2] += 6;
                                    break;
                                case "hard":
                                    deckValue[0] += (-2);
                                    deckValue[2] += 8;
                                    break;
                                default:

                                    break;
                            }
                        }
                        break;
                    case "normal":
                        deckValue[0] += 6;
                        foreach (string bet in bets)
                        {
                            switch (bet)
                            {
                                case "easy":
                                    deckValue[0] += 2;
                                    deckValue[2] += 4;
                                    break;
                                case "typical":
                                    deckValue[0] += 0;
                                    deckValue[2] += 6;
                                    break;
                                case "hard":
                                    deckValue[0] += (-2);
                                    deckValue[2] += 8;
                                    break;
                                default:

                                    break;
                            }
                        }
                        break;
                    case "strong":
                        deckValue[0] += 9;
                        foreach (string bet in bets)
                        {
                            switch (bet)
                            {
                                case "easy":
                                    deckValue[0] += 2;
                                    deckValue[2] += 4;
                                    break;
                                case "typical":
                                    deckValue[0] += 0;
                                    deckValue[2] += 6;
                                    break;
                                case "hard":
                                    deckValue[0] += (-2);
                                    deckValue[2] += 8;
                                    break;
                                default:

                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }


            int triadsOfPositive = deckValue[0] / 3;
            deckValue[2] = deckValue[2] - triadsOfPositive;

            List<string> figures = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            List<string> deckFive = new List<string>();
            for (int i = 0; i < deckValue[0]; i++)
            {
                string figure = figures[i];
                deckFive.Add("H" + figure);
            }

            for (int i = 0; i < deckValue[1]; i++)
            {
                string figure = figures[i];
                deckFive.Add("D" + figure);
            }

            for (int i = 0; i < deckValue[2]; i++)
            {
                string figure = figures[i];
                deckFive.Add("C" + figure);
            }
            foreach (string card in deckFive)
            {
                Console.WriteLine(card);
            }

            for (int cardNum = 0; cardNum < 10; cardNum++)
            {
                Random random = new Random();
                int firstCardNum = random.Next(deckFive.Count);
                int secondCardNum = random.Next(deckFive.Count);
                while (secondCardNum == firstCardNum)
                    secondCardNum = random.Next(deckFive.Count);

                string firstCard = deckFive[firstCardNum];
                string secondCard = deckFive[secondCardNum];
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
                }

                if (firstCard.StartsWith("C"))
                {
                    if (secondCard.StartsWith("H"))
                    {
                        handValue = handValue + "Tie";
                    }
                    else
                    {
                        handValue = handValue + "Loss";
                    }
                }

                if (firstCard.StartsWith("D") || firstCard.StartsWith("S"))
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

                }
            }
        }
    }
}