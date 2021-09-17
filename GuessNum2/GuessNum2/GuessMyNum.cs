using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNum2
{
    class GuessMyNum
    {

      
       protected int winRate=0;
       protected int[] numberOfAttempts = new int[] { };
       protected  int value;
       protected int numlevels;
      
        public GuessMyNum() 
        {
            Console.WriteLine("Start game!");
            Random rnd = new Random();
            value = rnd.Next(0, 100);
        }
        public void IsItRight()
        {
            Console.WriteLine("Enter number levels:\n");
            numlevels = Convert.ToInt32(Console.ReadLine());
            int[] numberOfAttempts = new int[numlevels];
            for (int i = 0; i < numberOfAttempts.Length; i++)
            {
                Console.WriteLine($"Enter num of attempts on {i + 1} level:\n");
                numberOfAttempts[i] = Convert.ToInt32(Console.ReadLine());
            }
            int yourNum;
            for (int i=0;i< numberOfAttempts.Length;i++)
            {
                Console.WriteLine($"This is {i + 1} level!\nEnter your num to guess:\n");
                for (int j = 0; j <= numberOfAttempts[i]; j++)
                {
                    yourNum = Convert.ToInt32(Console.ReadLine());
                    if  (yourNum > value)
                        {
                            Console.WriteLine("Your num is too high.Try again!\n");
                        }
                        else if (yourNum < value)
                        {
                            Console.WriteLine("Your num is too small.Try again!\n");
                        }
                        else
                        {
                        if (i != numberOfAttempts.Length)
                        {
                            Console.WriteLine("You win this level!!\n");
                            winRate++;
                        }
                        else
                        {
                            Console.WriteLine("You win game!!\n");
                        }
                        Random rnd = new Random();
                        value = rnd.Next(0, 100);
                    }
                    if (winRate == i + 1)
                    {
                        j = numberOfAttempts[i];
                    }
                   
                }
            }
            
        }
    }
}
