using System;

namespace MobilePhoneDevice
{
    class CallHistoryTest
    {
        public void HistoryTest()
        {
            Console.WriteLine(new string('-', 30));

            GSM phone = new GSM();
            phone.AddCalls(new Call(new DateTime(2015,03,10,18,15,20),"+359888555555",66));
            phone.AddCalls(new Call(new DateTime(2015, 03, 10, 19, 15, 00), "+359888444444", 16));
            phone.AddCalls(new Call(new DateTime(2015, 03, 11, 10, 10, 10), "+359888333333", 77));

            PrintCallsHistory(phone);

            double totalPrice = phone.CallsTotalPrice();
            Console.WriteLine("Total price: {0:F2} lv.", totalPrice);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Remove longest call");
            int longestCall = RemoveLongestCall(phone);
            phone.DeleteCalls(phone.CallHistory[longestCall]);

            PrintCallsHistory(phone);

            totalPrice = phone.CallsTotalPrice();
            Console.WriteLine("Total price: {0:F2} lv.", totalPrice);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Clear call history");
            phone.ClearCallHistory();
            PrintCallsHistory(phone);
       }

        private static int RemoveLongestCall(GSM phone)
        {
            int longestCall = 0;
            for (int i = 1; i < phone.CallHistory.Count; i++)
            {
                if (phone.CallHistory[longestCall].CallDuration < phone.CallHistory[i].CallDuration)
                {
                    longestCall = i;
                }
            }
            return longestCall;
        }

        private static void PrintCallsHistory(GSM phone)
        {
            Console.WriteLine("Calls history:");
            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine("{0}, {1}, {2} seconds", call.Date, call.PhoneNumber, call.CallDuration);
            }
        }
        
        
    }

    
}
