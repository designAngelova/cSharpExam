using System;
 
class Bittris
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        int score = 0, bitCount = 0;
        byte[] field = new byte[4];
 
        for (int i = 0; i < N / 4; i++)
        {
            uint number = uint.Parse(Console.ReadLine());
            byte currPos = 0, currNum = 0, leftBit = 0, rightBit = 0, counter = 0;
            currNum = (byte)number;
 
            // count the 1-bits in the number and the most-left and most-right position of the piece
            for (int bits = 0; bits < 32; bits++)
            {
                byte bit = (byte)(number >> bits & 1);
                if (bit == 1)
                {
                    if (counter == 0)
                    {
                        rightBit = (byte)bits;
                    }
                    leftBit = (byte)bits;
                    bitCount++;
                    counter++;
                }
            }
            field[currPos] = currNum;
 
            counter = 0;
            byte currRow = 0;
            for (int j = 0; j < 3; j++)
            {
                string direction = Console.ReadLine();
 
                if (counter != 0)
                {
                    continue;
                }
                if (direction == "D")  // move DOWN
                {
                    MoveDown(field, ref currPos, currNum, ref counter, ref direction);
                }
                else if (direction == "R")  // move RIGHT
                {
                    if (rightBit == 0 || (field[currPos] >> (rightBit - 1) & 1) == 1)
                    {
                        MoveDown(field, ref currPos, currNum, ref counter, ref direction);
                    }
                    else
                    {
                        currRow = (byte)(field[currPos] ^ currNum);
                        currNum = (byte)(currNum >> 1);
                        MoveDown(field, ref currPos, currNum, ref counter, ref direction);
                        if (counter > 0)
                        {
                            field[currPos - 1] = currNum;
                        }
                        else
                        {
                            field[currPos - 1] = currRow;
                        }
                        rightBit--;
                        leftBit--;
                    }
                }
                else  // move LEFT
                {
                    if (leftBit == 7 || (field[currPos] >> (leftBit + 1) & 1) == 1)
                    {
                        MoveDown(field, ref currPos, currNum, ref counter, ref direction);
                    }
                    else
                    {
                        currRow = (byte)(field[currPos] ^ currNum);
                        currNum = (byte)(currNum << 1);
                        MoveDown(field, ref currPos, currNum, ref counter, ref direction);
                        if (counter > 0)
                        {
                            field[currPos - 1] = currNum;
                        }
                        else
                        {
                            field[currPos - 1] = currRow;
                        }
                        leftBit++;
                        rightBit++;
                    }
                }
                //for (int k = 0; k < 4; k++)
                //{
                //    Console.WriteLine(Convert.ToString(field[k], 2).PadLeft(8, '0'));
                //}
            }
 
            // check if there is full row
            for (int j = 0; j < 4; j++)
            {
                if (field[j] == 255)  // if tehere is - drag the rows above with 1 position
                {
                    score += bitCount * 10;  
                    for (; j >= 1; j--)
                    {
                        field[j] = field[j - 1];
                        field[j - 1] = 0;
                    }
                    bitCount = 0;
                }
            }
 
            score += bitCount;
            bitCount = 0;
            //for (int k = 0; k < 4; k++)
            //{
            //    Console.WriteLine(Convert.ToString(field[k], 2).PadLeft(8, '0'));
            //}
            //Console.WriteLine(score);
        }
        Console.WriteLine(score);
    }
    // MOVE DOWN METHOD
    private static void MoveDown(byte[] field, ref byte currPos, byte currNum, ref byte counter, ref string direction)
    {
        if (field[currPos + 1] != 0)  //if the row below is not empty
        {
            for (int pos = 0; pos < 8; pos++)
            {
                byte bit = (byte)(currNum >> pos & 1);
                if (bit == 1)
                {
                    bit = (byte)(field[currPos + 1] >> pos & 1);
                    if (bit == 1)
                    {
                        direction = "No";
                        counter++;
                    }
                }
            }
            if (direction != "No")
            {
                field[currPos] ^= currNum;
                field[currPos + 1] ^= currNum;
            }
        }
        else  // if the row below is empty
        {
            field[currPos] ^= currNum;
            field[currPos + 1] ^= currNum;
        }
        currPos++;
    }
}