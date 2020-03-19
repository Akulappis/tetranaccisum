using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongTetranacci
{
    //Tetranacci sequence:( 0, 1, 1, 2 initialization sequence), 4(1st value), 8, 15, 29, 56, 108, 208, 401, 773, 1490(10th value), 2872, 5536, 10671, 20569....
    //Find 15th even tetranacci number and calculate sum of its digits eg. 123-->1+2+3=6
    class Program
    {
        public static void Tetranacci()
        {
            int nThEven = 0;
            int nThNotEven = 0;

            int[] sumOfValues = new int[2];
            

            int tetranacciValue = 0;
            int t1 = 0;
            int t2 = 1;
            int t3 = 1;
            int t4 = 2;

            while(sumOfValues[1] < 1)
            {
                tetranacciValue = t1 + t2 + t3 + t4;
                t1 = t2;
                t2 = t3;
                t3 = t4;
                t4 = tetranacciValue;
                if (tetranacciValue % 2 == 0)
                {
                    nThEven++;
                }
                else
                {
                    nThNotEven++;
                }
                if (nThEven == 15)
                {
                    char[] digits = tetranacciValue.ToString().ToCharArray();
                    for (int i = 0; i < digits.Length; i++)
                    {
                        sumOfValues[0] = sumOfValues[0] + (int)Char.GetNumericValue(digits[i]);
                    }
                }
                if (nThNotEven == 15)
                {
                    char[] digits = tetranacciValue.ToString().ToCharArray();
                    for (int i = 0; i < digits.Length; i++)
                    {
                        sumOfValues[1] = sumOfValues[1] + (int)Char.GetNumericValue(digits[i]);
                    }
                }
            }
            Console.WriteLine(sumOfValues[0] + " Sum of even numbers values");
            Console.WriteLine(sumOfValues[1] + " Sum of odd numbers values");

        }

        static void Main()
        {
            Tetranacci();
            Console.Read();
        }

    }
}
