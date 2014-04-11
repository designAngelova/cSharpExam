using System;
 
class BitBall
{
    static void Main()
    {
        byte[] topTeam = new byte[8];
        byte[] bottomTeam = new byte[8];
        for (int i = 0; i < 8; i++)
        {
            topTeam[i] = byte.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 8; i++)
        {
            bottomTeam[i] = byte.Parse(Console.ReadLine());
        }
        int mask = 1;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                mask = 1;
                mask = mask << j;
                if ((topTeam[i] & mask) >= 1 && (bottomTeam[i] & mask) >= 1)
                {
                    topTeam[i] = (byte)(topTeam[i] ^ mask);
                    bottomTeam[i] =  (byte)(bottomTeam[i] ^ mask);
                }
            }
        }
        int topTeamScore = 0;
        int finalPlayer = -1;
        bool score = true;
        for (int i = 0; i < 8; i++)
        {
            finalPlayer = -1;
            score = true;
            mask = 1;
            mask = mask << i;
            for (int j = 0; j < 8; j++)
            {
                if ((topTeam[j] & mask) >= 1)
                {
                    finalPlayer = j;
                }
            }
            if (finalPlayer != -1 && finalPlayer != 7)
            {
                for (int k = finalPlayer + 1; k < 8; k++)
                {
                    if ((bottomTeam[k] & mask) >= 1)
                    {
                        score = false;
                    }
                }
            }
            if (score && (finalPlayer != -1))
            {
                topTeamScore++;
            }
        }
        int bottomTeamScore = 0;
        for (int i = 0; i < 8; i++)
        {
            finalPlayer = -1;
            score = true;
            mask = 1;
            mask = mask << i;
            for (int j = 7; j >= 0; j--)
            {
                if ((bottomTeam[j] & mask) >= 1)
                {
                    finalPlayer = j;
                }
            }
            if (finalPlayer > 0)
            {
                for (int k = finalPlayer - 1; k >= 0; k--)
                {
                    if ((topTeam[k] & mask) >= 1)
                    {
                        score = false;
                    }
                }
            }
            if (score && (finalPlayer != -1))
            {
                bottomTeamScore++;
            }
        }
        Console.WriteLine("{0}:{1}", topTeamScore, bottomTeamScore);
    }
}
   





//Method that take a bits in position  static int GetBitOnPosition(int number, int position)
    //{
    //    return (number & (1 << position)) > 0 ? 1 : 0;
    //}






