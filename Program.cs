using System;
using System.Threading.Channels;

namespace Module4Assignment
{
    class Program
    {
        static void NumberSeries()
        {
            int startNumber = 0;
            int endNumber = 0;
            int oddNumbers = 0;
            int evenNumbers = 0;
            double evenCalc = 0;
            double oddCalc = 0;


            Console.Write("Starting Number>");
            Int32.TryParse(Console.ReadLine(), out startNumber);


            Console.Write("Ending Number>");

            Int32.TryParse(Console.ReadLine(), out endNumber);

            if (startNumber < endNumber)
            {
                Console.WriteLine($"Starting number: {startNumber}");
                Console.WriteLine($"Ending number: {endNumber}");

                while (startNumber <= endNumber)
                {
                    if (startNumber % 2 == 0)
                    {
                        evenNumbers++;
                    }
                    else
                    {
                        oddNumbers++;
                    }
                    
                    
                    
                    startNumber++;
                }
            }
            else
            {
                Console.WriteLine($"Invalid: Start: {startNumber} must be LESS than End: {endNumber}");
                if (startNumber % 2 == 0)
                {
                    evenNumbers++;
                }
                else
                {
                    oddNumbers++;
                }

                if (endNumber % 2 == 0)
                {
                    evenNumbers++;
                }
                else
                {
                    oddNumbers++;
                }

                Console.WriteLine($"Even numbers: {evenNumbers}");
                Console.WriteLine($"Odd numbers: {oddNumbers}");
            }
            
            Console.WriteLine($"Even numbers: {evenNumbers}");
            Console.WriteLine($"Odd numbers: {oddNumbers}");
        }

        static void Main(string[] args)
        {
            NumberSeries();
        }
    }
}