using System;

namespace MobilePhoneDevice
{
    public class MobilePhoneDevice
    {
        static void Main()
        {
            try
            {
                GSMTest gsmTest = new GSMTest();
                gsmTest.PrintPhonesDetails();

                CallHistoryTest callHistoryTest = new CallHistoryTest();
                callHistoryTest.HistoryTest();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
