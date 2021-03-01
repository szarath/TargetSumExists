using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TargetSumExists
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Assert((TargetSumExistsInTwoNumbers(new[] { 10, 20 }, 30)));
            Debug.Assert(TargetSumExistsInTwoNumbers(new[] { 10, 20 }, 35) == false);
            Debug.Assert((TargetSumExistsInTwoNumbers(new[] { 10, 20 }, 40)));
            Debug.Assert((TargetSumExistsInTwoNumbers(new[] { -9, 10 }, 1)));
            Debug.Assert(TargetSumExistsInTwoNumbers(new[] { 10, -8 }, 1) == false);
            Debug.Assert((TargetSumExistsInTwoNumbers(new[] { 10, 2, 4, -9, 6 }, 1)));
            Debug.Assert(TargetSumExistsInTwoNumbers(new[] { 2, 4, -9, 6 }, 1) == false);
             Debug.Assert((TargetSumExistsInThreeNumbers(new []{2, 4, 10, 5, -9}, 3)));
             Debug.Assert(TargetSumExistsInThreeNumbers(new []{2, 4, 10, 5, -9}, 170) == false);
            Console.WriteLine("Done!");
        }

        private static bool TargetSumExistsInTwoNumbers(int[] list, int target)
        {
           
            for (int i = 0; i < list.Length;i++)
                {
                for (int a = 0; a < list.Length; a++)
                {
                    if (list[i] + list[a]  == target)
                    {
                        return true;
                    
                    }

                    

                }
                   
            
            
                }

            // Your code goes here
            return false;
        }

        private static bool TargetSumExistsInThreeNumbers(int[] list, int target)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int a = 0; a < list.Length; a++)
                {
                    for (int b = 0; b < list.Length; b++)
                    {
                        if (list[i] + list[a] + list[b] == target)
                        {
                            return true;

                        }

                    }

                }



            }
            // Your code goes here
            return false;
        }
    }
}