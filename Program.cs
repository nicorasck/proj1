﻿namespace proj1;

class Program
    {
    static void Main(string[] args)
        {
             Console.WriteLine("Program begin");

            int sum = 0;

            for (int i = 0; i < 4; i++)
            {
                sum += i;
                Console.WriteLine($"i = {i}\nsum ={sum}");

                if (sum == 3)
                {
                    Console.WriteLine("We have now the magical sum of 3\n");
                }
            }
            Console.WriteLine("\nProgram end.");
        }
    }


