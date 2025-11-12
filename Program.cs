using System;

namespace ExceptionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                Console.WriteLine($"You entered: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }

            Console.WriteLine("\n---------------------------------\n");

            // Calling second example
            PasswordCheck();
        }

        // 2️⃣ Password validation method
        static void PasswordCheck()
        {
            try
            {
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
