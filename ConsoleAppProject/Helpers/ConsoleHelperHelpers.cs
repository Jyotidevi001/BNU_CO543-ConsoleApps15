using System;

namespace ConsoleAppProject.Helpers
{
    internal static class ConsoleHelperHelpers
    {


        /// <summary>
        /// 
        /// </summary>

        public static double InputNumber(string prompt, double min, double max)
        {
            bool isValid;
            double number;

            do
            {
                number = InputNumber(prompt);

                if (number < min || number > max)
                {
                    isValid = false;
                    Console.WriteLine($"Number must be between {min} and {max}");
                }
                else isValid = true;

            } while (!isValid);

            return number;

        }
    }
}