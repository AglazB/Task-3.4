using System;
using Task_3_4;

namespace Task_3._4
{
	public class DoubleValue : IValue<double>
    {
		public double RandomValue()
		{
            Random random = new Random();
			return random.NextDouble() * random.Next(1, 1000);
        }
		public double ManualValue()
		{
			return double.Parse(Console.ReadLine());
		}
	}
}

