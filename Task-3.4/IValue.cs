using System;
namespace Task_3_4
{
	public interface IValue<T>
	{
		T RandomValue();
		T ManualValue();
	}
}

