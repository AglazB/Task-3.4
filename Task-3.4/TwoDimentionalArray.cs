using System;
namespace Task_3_4
{
	public abstract class TwoDimentionalArray : IRoot
	{
        public int Rank()
        {
            return 2;
        }
        public abstract void Print();
    }
}

