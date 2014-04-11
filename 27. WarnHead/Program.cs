using System;
using System.Collections.Generic;
using System.IO;

class Warhead
{
    static void Main()
    {
#if DEBUG
        Console.SetIn(new StreamReader("../../input.txt"));
#endif
        int[] numbers = new int[16];

        for (int i = 0; i < 16; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine(), 2);
        }

        int currentRow = -1;
        int upperRow = -1;
        int lowerRow = -1;
        int mask = 0;

        List<int[]> figurePositions = new List<int[]>();
        int redCount = 0;
        int blueCount = 0;

        bool? cutRedWire = null; // null -> no wire has been cut; true -> red wire has been cut; false -> blue wire has been cut
        bool exploded = false;

        #region Figure Count
        /*
         * 111
         * 101
         * 111 
         */
        for (int row = 1; row <= 14; row++)
        {
            currentRow = numbers[row];
            upperRow = numbers[row - 1];
            lowerRow = numbers[row + 1];

            for (int bit = 15; bit >= 0; bit--)
            {
                mask = 1 << bit;
                if (((currentRow & mask) == 0) &&
                            ((upperRow & mask) > 0) &&
                            ((lowerRow & mask) > 0))
                {
                    mask <<= 1;
                    if (((currentRow & mask) > 0) &&
                            ((upperRow & mask) > 0) &&
                            ((lowerRow & mask) > 0))
                    {
                        mask >>= 2;
                        if (((currentRow & mask) > 0) &&
                            ((upperRow & mask) > 0) &&
                            ((lowerRow & mask) > 0))
                        {
                            // Figure found
                            figurePositions.Add(new[] { row, bit });
                            if (bit <= 7)
                            {
                                blueCount++;
                            }
                            else
                            {
                                redCount++;
                            }

                            bit -= 2;
                        }
                    }
                }
            }
        }
        #endregion

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "cut")
            {
                command = Console.ReadLine();
                if (command == "red")
                {
                    cutRedWire = true;
                    if (redCount > 0)
                    {
                        exploded = true;
                    }
                }
                else if (command == "blue")
                {
                    cutRedWire = false;
                    if (blueCount > 0)
                    {
                        exploded = true;
                    }
                }

                // First exit condition - cut one of the wires
                break;
            }
            else // hover or operate 
            {
                int currentPosY = int.Parse(Console.ReadLine()); // row -> element of the array
                int currentPosX = 15 - int.Parse(Console.ReadLine()); // column -> position in the current number
                mask = 1 << currentPosX;

                // Find the current rows - current, upper and lower on which to hover / operate
                currentRow = numbers[currentPosY];
                if (currentPosY == 0)
                {
                    upperRow = 0;
                    lowerRow = numbers[currentPosY + 1];
                }
                else if (currentPosY == 15)
                {
                    upperRow = numbers[currentPosY - 1];
                    lowerRow = 0;
                }
                else
                {
                    upperRow = numbers[currentPosY - 1];
                    lowerRow = numbers[currentPosY + 1];
                }

                if (command == "hover")
                {
                    if ((currentRow & mask) > 0)
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                }
                else if (command == "operate")
                {
                    if ((currentRow & mask) > 0)
                    {
                        exploded = true;
                        // Second exit condition - operate over a capacitor
                        break;
                    }

                    for (int i = 0; i < figurePositions.Count; i++)
                    {
                        // There is no figure - do nothing
                        if (!(currentPosY == figurePositions[i][0] &&
                            currentPosX == figurePositions[i][1]))
                        {
                            continue;
                        }
                        else
                        {
                            #region Remove all surrounding capacitors
                            mask = 1 << (15 - currentPosX - 1);
                            currentRow &= ~mask;
                            upperRow &= ~mask;
                            lowerRow &= ~mask;
                            mask >>= 1;
                            upperRow &= ~mask;
                            lowerRow &= ~mask;
                            mask >>= 1;
                            currentRow &= ~mask;
                            upperRow &= ~mask;
                            lowerRow &= ~mask;
                            #endregion

                            if (currentPosX <= 6)
                            {
                                blueCount--;
                            }
                            else
                            {
                                redCount--;
                            }

                            // Update map after removing capacitors
                            numbers[currentPosY] = currentRow;
                            if (currentPosY == 0)
                            {
                                numbers[currentPosY + 1] = lowerRow;
                            }
                            else if (currentPosY == 15)
                            {
                                numbers[currentPosY - 1] = upperRow;
                            }
                            else
                            {
                                numbers[currentPosY - 1] = upperRow;
                                numbers[currentPosY + 1] = lowerRow;
                            }
                        }
                    }
                }
            }
        }

        if (exploded)
        {
            if (cutRedWire.HasValue)
            {
                if (cutRedWire == true)
                {
                    Console.WriteLine(redCount);
                }
                else
                {
                    Console.WriteLine(blueCount);
                }
            }
            else
            {
                Console.WriteLine("missed");
                Console.WriteLine(redCount + blueCount);
            }

            Console.WriteLine("BOOM");
        }
        else
        {
            Console.WriteLine(redCount + blueCount);
            Console.WriteLine("disarmed");
        }
    }
}