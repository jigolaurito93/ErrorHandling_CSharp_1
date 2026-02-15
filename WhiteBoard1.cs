using System;

namespace ErrorHandling_CSharp
{
    public static class WhiteBoard1
    {
        public static void PrintWithFinally()
        {
            // TODO: Create a simple C# program that demonstrates the use of the finally block. The program should:
            // Declare a method PrintWithFinally which contains a try block that writes "Trying..." to the console.
            // Add a finally block that writes "Finally executed." to the console.
            // Ensure the finally block executes even if the try block does not throw an exception.

            try
            {
                Console.WriteLine("Trying...");
            }
            finally
            {
                Console.WriteLine("Finally executed.");
            }
        }
    }
}