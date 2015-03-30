using System;

namespace _3.RangeExceptions.Models
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string message,T start, T end, Exception innerException = null) : base(message, innerException)
        {
            this.Start = start;
            this.End = end;
        }

        public T End    
        {
            get { return end; }
            private set { end= value; }
        }
        
        public T Start
        {
            get { return start; }
            private set { start = value; }
        }
        
    }
}
