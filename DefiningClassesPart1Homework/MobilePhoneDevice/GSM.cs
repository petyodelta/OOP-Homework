using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhoneDevice
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Batteries battery;
        private Displays display;
        private List<Call> callHistory = new List<Call>();

        public static GSM iPhone4S = new GSM("4S", "Apple", 300, "Pesho",
                                    new Batteries("2000mAh", 150, 3,BatteryType.LiIon),
                                    new Displays(4, 16000000));

        public const double pricePerMinute = 0.37;

        public GSM() { }
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Batteries battery, Displays display)
            
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }
               
        public string Model 
        { 
            get
            {
                return this.model;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid model");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid manufacturer");
                }
                this.manufacturer = value;
            }
        }
        public decimal? Price
        { 
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid price");
                }
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public Batteries Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public Displays Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Model: " + this.Model);
            builder.AppendLine("Manufacturer: " + this.Manufacturer);
            builder.AppendLine("Price: " + this.Price);
            builder.AppendLine("Owner: " + this.Owner);
            builder.AppendLine("Battery model: " + this.Battery.Model);
            builder.AppendLine("Battery idle hours: " + this.Battery.HoursIdle);
            builder.AppendLine("Battery talk hours: " + this.Battery.HoursTalk);
            builder.AppendLine("Battery type: " + this.Battery.BatteryType);
            builder.AppendLine("Display size: " + this.Display.Size);
            builder.Append("Display colors: " + this.Display.Colors);

            return builder.ToString();
        }

        public void AddCalls(Call call)
        {
            this.CallHistory.Add(call);
        }
        public void DeleteCalls(Call call)
        {
            this.CallHistory.Remove(call);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public double CallsTotalPrice()
        {
            double totalSeconds = 0;
            foreach (var callDuration in callHistory)
            {
                totalSeconds += callDuration.CallDuration;
            }
            double totalMinutes = totalSeconds / 60;
            double callTotalPrice = totalMinutes * pricePerMinute;
            
            return callTotalPrice;
        }
    }
}
