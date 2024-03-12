using System;
namespace Task_3_4
{
	public class StringValue : IValue<string>
	{
        public string RandomValue() {
            Random random = new Random();
			int length = random.Next(1, 20);
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			string str = "";
			for (int i = 0; i < length; i++)
			{
				str += alphabet[random.Next(alphabet.Length)];

            }
			return str;
		}
		public string ManualValue()
		{
			return Console.ReadLine();
		}
	}
}



