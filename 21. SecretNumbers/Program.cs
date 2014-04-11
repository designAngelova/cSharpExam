           using System;
using System.Collections.Generic;
using System.Text;
  //class SecretNumbers
  //  {
  //      static void Main()
  //      {
            //string input = Console.ReadLine();
            //input = input.TrimStart('-');
            //var inputChar = input.ToCharArray();
            //Array.Reverse(inputChar);
            //long sum = 0;

            //for (int i = 0; i < inputChar.Length; i++)
            //{
            //    int currentDigit = int.Parse(inputChar[i].ToString());
            //    if (i % 2 == 1)
            //    {
            //        sum += currentDigit * currentDigit * (i + 1);

            //    }
            //    else
            //    {
            //        sum += currentDigit * (i + 1) * (i + 1);
            //    }
            //}
            //Console.WriteLine(sum);
            //int seqLength = (int)sum % 10;
            //int start =(int) sum % 26 + 1; 
 
 
    class Secreats
    {
        static void Main()
        {
            ulong specialSum = 0;
            string num = Console.ReadLine();
            byte alphaSeqLength = 0;
            ushort step = 1;
            for (int i = num.Length - 1; i >= 0; i--, step++)
            {
                int temp = 0;
                if (Char.IsDigit(num[i]))
                {
                    temp = int.Parse(num[i].ToString());
                }
                else
                {
                    continue;
                }
                if ((step & 1) == 1)
                {
                    specialSum += (ulong)(step * step * temp);
                }
                else
                {
                    specialSum += (ulong)(step * temp * temp);
                }
            }
            alphaSeqLength = (byte)(specialSum % 10);
            StringBuilder alphaSeq = new StringBuilder();
            sbyte startLetter = (sbyte)(specialSum % 26);
            for (byte i = 0; i < alphaSeqLength; i++)
            {
                if (startLetter + 'A' + i > 'Z')
                {
                    startLetter = (sbyte)(-i);
                }
                alphaSeq.Append((char)(startLetter + 'A' + i));
            }
            if (num != "")
            {
                Console.WriteLine(specialSum);
            }
            if (alphaSeqLength != 0)
            {
                Console.WriteLine(alphaSeq.ToString());
            }
            else
            {
                Console.WriteLine("{0} has no secret alpha-sequence", num);
            }
        }
    }





