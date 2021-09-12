using System;

namespace Module4Assignment
{
    class Program
    {

        static void NumberSeries()
        {
            int startNumber = 0;
            int endNumber = 0;

            Console.WriteLine("Starting Number>");
            Console.WriteLine("Ending Number>");
            
            Int32.TryParse(Console.ReadLine(), out startNumber);
            Int32.TryParse(Console.ReadLine(), out endNumber);

            if (startNumber < endNumber)
            {
                
            }
            else
            {
                Console.WriteLine("Error: Starting number must be LESS than ending number.");
            }


        }
        static void Main(string[] args)
        {
            
        }
    }
}