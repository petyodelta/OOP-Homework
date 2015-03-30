using System;

namespace MobilePhoneDevice
{
    class Displays
    {
        private double? size;
        private uint? colors;
        
        public Displays(double? size, uint? colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
        
        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid display size");
                }
                this.size = value;
            }
        }
        public uint? Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid number of colors");
                }
                this.colors = value;
            }
        }
    }
}
