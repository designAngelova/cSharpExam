using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CardWars
{
    class CardWars
    {
        static void Main(string[] args)
        {
            //using string and integer arrays
            int allGames = int.Parse(Console.ReadLine());
            const int cardsPerGame = 3;
            int[] points = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13 };
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };
            BigInteger totalFirst = 0;
            BigInteger totalSecond = 0;
            bool firstX = false;
            bool secondX = false;
            int wonFirst = 0;
            int wonSecond = 0;
            bool gameWon = false;
            for (int k = 0; k < allGames; k++)
            {
                int scoreFirst = 0;
                int scoreSecond = 0;
                string[] firstPlayer = { "0", "0", "0" };
                string[] secondPlayer = { "0", "0", "0" };
                for (int i = 0; i < cardsPerGame; i++)
                {
                    firstPlayer[i] = Console.ReadLine();
                    if (firstPlayer[i] == "X")
                    {
                        firstX = true;
                    }
                    if (firstPlayer[i] == "Y")
                    {
                        totalFirst -= 200;
                    }
                    if (firstPlayer[i] == "Z")
                    {
                        totalFirst *= 2;
                    }
                }

                for (int i = 0; i < cardsPerGame; i++)
                {
                    secondPlayer[i] = Console.ReadLine();
                    if (secondPlayer[i] == "X")
                    {
                        secondX = true;
                    }
                    if (secondPlayer[i] == "Y")
                    {
                        totalSecond -= 200;
                    }
                    if (secondPlayer[i] == "Z")
                    {
                        totalSecond *= 2;
                    }
                }
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < cardsPerGame; j++)
                    {
                        if (firstPlayer[j] == cards[i])
                        {
                            scoreFirst += points[i];
                        }
                        if (secondPlayer[j] == cards[i])
                        {
                            scoreSecond += points[i];
                        }
                    }

                }

                if (firstX && secondX)
                {
                    totalFirst += 50;
                    totalSecond += 50;
                    firstX = false;
                    secondX = false;
                }
                if (scoreFirst > scoreSecond)
                {
                    totalFirst += scoreFirst;
                    wonFirst++;
                }
                else if (scoreSecond > scoreFirst)
                {
                    totalSecond += scoreSecond;
                    wonSecond++;
                }
            }
            if (firstX && !secondX)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                gameWon = true;
            }
            else if (!firstX && secondX)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                gameWon = true;
            }
            if ((totalFirst > totalSecond) && !gameWon)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", totalFirst);
                Console.WriteLine("Games won: {0}", wonFirst);
            }
            else if ((totalFirst < totalSecond) && !gameWon)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", totalSecond);
                Console.WriteLine("Games won: {0}", wonSecond);
            }
            else if ((totalFirst == totalSecond) && !gameWon)
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", totalFirst);
            }
        }
    }
}