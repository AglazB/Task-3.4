using System;
namespace Task_3_4
{
	public class IntValue : IValue<int>
	{
		public int RandomValue()
		{
			return new Random().Next(-100, 100);
		}
        public int ManualValue()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}

