using System;

namespace ErrorHandling_CSharp
{
    public static class TryCatch
    {
        public static void usingTryCatch()
        {

            int result = 0;

            try
            {
                Console.WriteLine("Please enter a number:");
                //int num1 = int.Parse(Console.ReadLine());
                int num1 = 1;
                int num2 = 2;
                result = num2 / num1;
                Console.WriteLine($"The result of dividing {num2} by {num1} is: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input was not in a correct format. Please enter a valid number.");
                Console.WriteLine($"Error details: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Error details: {ex.Message}");
            }
            finally
            {
                // Code to clean up or finalize
                // Ideal for cleaning up resources
                // Like closing file streams, database connections, etc.
                Console.WriteLine("This block will always execute, regardless of whether an exception was thrown or not.");
            }



        }
    }
}