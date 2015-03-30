using System;
using _3.RangeExceptions.Models;

namespace _3.RangeExceptions
{
    class RangeExceptionsMain
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter number in range [1...100]:");
                int number = int.Parse(Console.ReadLine());
                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Number must be in range [1...100]", 1, 100);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.Write("Enter date in range [1.1.1980-31.12.2013]:");
                DateTime date = DateTime.Parse(Console.ReadLine());
                var startDate = new DateTime(1980, 1, 1);
                var endDate = new DateTime(2013, 12, 31);
                if (date < startDate || date > endDate)
                {
                    throw new InvalidRangeException<DateTime>("Date must be in range [1.1.1980-31.12.3013]", startDate, endDate);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);            
            }
        }
    }
}
