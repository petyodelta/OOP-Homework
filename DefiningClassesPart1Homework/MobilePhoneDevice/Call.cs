using System;

namespace MobilePhoneDevice
{
    class Call
    {
        private DateTime date;
        private string phoneNumber;
        private uint callDuration;

        public Call(DateTime date,string phoneNumber, uint callDuration)
        {
            this.Date = date;
            this.PhoneNumber = phoneNumber;
            this.CallDuration = callDuration;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }
        public uint CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Call duration can not be negative number");
                }
                this.callDuration = value;
            }
        }
    }
}
