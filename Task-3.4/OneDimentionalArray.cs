using System;
using System.Collections;

namespace Task_3_4
{
    public sealed class OneDimentionalArray<T> : IRoot
    {
        private T[] Array;
        private IValue<T> val;
        public OneDimentionalArray(IValue<T> val, int length, bool manualEntry = false)
        {
            this.val = val;
            if (manualEntry)
            {
                ManualEntry(length);
            }
            else
            {
                AutoEntry(length);
            }
        }
 
        private void ManualEntry(int length)
        {
            int n = length;
            Array = new T[n];
            for (int i = 0; i < n; i++)
            {
                Array[i] = val.ManualValue();
            }
        }

        private void AutoEntry(int length)
        {
            Random rnd = new Random();
            int n = length;
            Array = new T[n];
            for (int i = 0; i < n; i++)
            {
                Array[i] = val.RandomValue();
            }
        }

        
        public int Rank()
        {
            return 1;
        }
        
        public void Print()
        {
            Console.WriteLine(string.Join(" ", Array));
        }
    }
}

