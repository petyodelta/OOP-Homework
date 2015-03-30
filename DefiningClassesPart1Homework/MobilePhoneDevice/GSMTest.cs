using System;

namespace MobilePhoneDevice
{
    class GSMTest
    {
        private GSM[] gsmPhones = { new GSM("Galaxy S6","Samsung",1200,"Gosho", new Batteries("2600mAh", 800, 11, BatteryType.LiIon),new Displays(5.1,16000000)),
            new GSM("Nexus 5", "LG", 600, "Ivan", new Batteries("2500mAh", 700, 9, BatteryType.LiIon), new Displays(5, 16000000))};

        public void PrintPhonesDetails()
        {
            Console.WriteLine(gsmPhones[0].ToString());
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(gsmPhones[1].ToString());
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(GSM.iPhone4S.ToString());
        }
    }
}
