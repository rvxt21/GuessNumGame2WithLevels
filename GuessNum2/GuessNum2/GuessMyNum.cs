using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNum2
{
    class GuessMyNum
    {

        int tries_count;
        int winRate;
        int[] numberOfAttempts = new int[] { 10, 7, 5 };
        int value;
        public GuessMyNum() 
        {
            Console.WriteLine("Start game!");
            Random rnd = new Random();
            value = rnd.Next(0, 100);
        }

        public void IsItRight()
        {
            Console.WriteLine("Enter your num:\n");
            int yourNum;
            int j = 0;
            for (int i = 0; i < numberOfAttempts[j]; i++) 
            {
                yourNum = Convert.ToInt32(Console.ReadLine());
                if (yourNum > value)
                {
                    Console.WriteLine("Your num is too high.Try again!\n");
                }
                else if (yourNum < value)
                {
                    Console.WriteLine("Your num is too small.Try again!\n");
                }
                else
                {
                    if (j != 2) {
                        Console.WriteLine("You win this level!\n");
                    }
                    else if (j == 2)
                    {
                        Console.WriteLine("You win this game!!");
                    }
                    j++;
                    Random rnd = new Random();
                    value = rnd.Next(0, 100);
                }
            }
        }
    }
}
