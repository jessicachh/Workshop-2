using System;

namespace LoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1️⃣ For loop — Sum from 1 to N
            Console.Write("Enter a number (N): ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum from 1 to {N} = {sum}");

            Console.WriteLine("\n---------------------------------\n");

            // 2️⃣ While loop — Print numbers from 1 to 20
            // Skip multiples of 4, stop when number is 15
            int num = 1;
            while (num <= 20)
            {
                if (num == 15)
                {
                    Console.WriteLine("Reached 15, stopping loop.");
                    break;
                }

                if (num % 4 == 0)
                {
                    num++;
                    continue; // Skip multiples of 4
                }

                Console.WriteLine(num);
                num++;
            }

            Console.WriteLine("\n---------------------------------\n");

            // 3️⃣ Foreach loop — Sum of all elements in an array
            int[] numbers = { 2, 4, 6, 8, 10 };
            int total = 0;

            foreach (int val in numbers)
            {
                total += val;
            }

            Console.WriteLine("Sum of all elements in array: " + total);

            Console.ReadLine();
        }
    }
}
