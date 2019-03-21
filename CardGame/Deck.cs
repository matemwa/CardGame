using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace CardGame
{
    public class SetDeck
    {
        string[] inputFile = File.ReadAllLines(Program.filePath);

        public List<string> GetDeck(List<int> rows)
        {
            List<string> Deck = new List<string>();
            try
            {
                for (int j = 0; j < rows.Count; j++)
                {
                    int i = rows[j];
                    List<string> colorsSelect = new List<string>();
                    List<string> colors = new List<string> { "H", "D", "C", "S" };
                    List<string> figures = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
                    string currentCard;

                    if (inputFile[i].StartsWith("D") ||
                    inputFile[i].StartsWith("H") ||
                    inputFile[i].StartsWith("C") ||
                    inputFile[i].StartsWith("S") ||
                    inputFile[i].StartsWith("[") )
                    {
                        if (inputFile[i].StartsWith("["))
                        {
                            colorsSelect = colors;
                        }

                        else
                        {

                            string color1 = inputFile[i].Substring(0, inputFile[i].LastIndexOf('['));
                            foreach (char color in color1)
                            {
                                colorsSelect.Add(color.ToString());
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid deck card in line {0} of the input file.", j);
                    }

                    // Operating on the string to get the figures range.

                    string startValue = inputFile[i].Trim(']').Substring(inputFile[i].LastIndexOf("[") + 1, inputFile[i].LastIndexOf('-') - inputFile[i].LastIndexOf('[') - 1);
                    string endValue = inputFile[i].Trim(']').Substring(inputFile[i].LastIndexOf("-") + 1);

                    // Setting a range in integers for figures
                    int startIndex = figures.IndexOf(startValue);
                    int endIndex = figures.IndexOf(endValue);
                    var figuresSelect = figures.Skip(startIndex).Take(endIndex - startIndex);

                    // This function creates a card and adds it to the Deck, from previously chosen figures and colors.

                    foreach (string color in colorsSelect)
                    {
                        foreach (string figure in figuresSelect)
                        {
                            currentCard = color + figure;
                            Deck.Add(currentCard);
                        }
                    }
                }
                return Deck;
            }

            catch (Exception)
            {
                
            }

            return Deck;

        }
    }
}
