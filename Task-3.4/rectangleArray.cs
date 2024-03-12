using System;
namespace Task_3_4
{
    public sealed class RectangleArray<T> : TwoDimentionalArray
    {

        T[,] Array;
        private IValue<T> val;
        public RectangleArray(IValue<T> val, int length1, int length2, bool manualEntry = false)
        {
            this.val = val;
            if (manualEntry)
            {
                ManualEntry(length1, length2);
            }
            else
            {
                AutoEntry(length1, length2);
            }
        }
        private void ManualEntry(int length1, int length2)
        {
            int n = length1;
            int m = length2;
            Array = new T[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Array[i, j] = val.ManualValue();
                }
            }
        }
        private void AutoEntry(int length1, int length2)
        {
            Random rnd = new Random();
            int n = length1;
            int m = length2;
            Array = new T[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Array[i, j] = val.RandomValue();
                }
            }
        }
        
        public override void Print()
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write($"{Array[i, j]} ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }
        

    }
}

