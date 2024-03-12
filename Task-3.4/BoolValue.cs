using System;
namespace Task_3_4
{
	public class BoolValue : IValue<bool>
    {
		public bool RandomValue()
		{
			Random random = new Random();
			bool[] Bool = { true, false };
			return Bool[random.Next(Bool.Length)];
		}
		public bool ManualValue() {
			return bool.Parse(Console.ReadLine());
		}
	}
}

