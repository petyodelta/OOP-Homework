using System;

namespace MobilePhoneDevice
{
    class Batteries
    {
        private string model;
        private ushort? hoursIdle;
        private ushort? hoursTalk;
        private BatteryType batteryType;        
        
        public Batteries(string model)
        {
            this.Model = model;
        }
        public Batteries(string model, ushort? hoursIdle, ushort? hoursTalk)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
        public Batteries(string model, ushort? hoursIdle, ushort? hoursTalk, BatteryType batteryType)
            : this(model,hoursIdle, hoursTalk)
        {
            this.BatteryType = batteryType;
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
                    throw new ArgumentNullException("Invalid battery model");
                }
                this.model = value;
            }
        }
        public ushort? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid battery idle hours");
                }
                this.hoursIdle = value;
            }
        }
        public ushort? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid battery talk hours");
                }
                this.hoursTalk = value;
            }
        }
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

    }
    public enum BatteryType { LiIon, NiMH, NiCd }
}
