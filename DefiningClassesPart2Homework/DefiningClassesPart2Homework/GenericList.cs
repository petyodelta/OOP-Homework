using System;
using System.Text;

namespace DefiningClassesPart2Homework
{
    class GenericList<T>
         where T: IComparable 
    {
        private T[] array;
        private int count;
        private int _capacity;

        public GenericList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException("Capacity can not be negative or zero");
            }
            this.Capacity = capacity;
            this.array = new T[this.Capacity];
            this.Count = 0;
        }

        
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                this._capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            private set
            {
                this.count = value;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }
                return this.array[index];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }
                this.array[index] = value;
            }
        }

        public void AddElement(T element)
        {
            if (this.Count == this.Capacity)
            {
                var oldArray = array;
                this.Capacity *= 2;
                this.array = new T[this.Capacity];
                Array.Copy(oldArray, this.array, this.Count);
            }
            this.array[this.Count] = element;
            ++this.Count;
        }

        public T GetElement(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }
            return this.array[index];
        }

        public void RemoveElement(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }
            for (int i = index; i < this.Count - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
            --this.Count;
        }

        public void InsertElement(T element, int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }
            if (this.Count == this.Capacity)
            {
                var oldArray = array;
                this.Capacity *= 2;
                this.array = new T[this.Capacity];
                Array.Copy(oldArray, this.array, this.Count);
            }
            for (int i = this.Count; i >= index + 1; i--)
            {
                this.array[i] = this.array[i - 1];
            }
            this.array[index] = element;
            ++this.Count;
        }

        public void ClearList()
        {
            this.array = new T[this.Capacity];
            this.Count = 0;
        }

        public int FindElement(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public T Min()
        {
            T minElement = this.array[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (minElement.CompareTo(this.array[i]) > 0)
                {
                    minElement = this.array[i];
                }
            }
            return minElement;
        }

        public T Max()
        {
            T maxElement = this.array[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (maxElement.CompareTo(this.array[i]) <= 0)
                {
                    maxElement = this.array[i];
                }
            }
            return maxElement;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                builder.Append(this.array[i]);
                builder.Append(" ");
            }

            return builder.ToString();
        }
    }
}
