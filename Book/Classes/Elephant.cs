using System;
namespace Book.Classes
{
	public class Elephant
	{
		public string Name;
        public short EarSize;

		public void	WhoAml()
		{

			Console.WriteLine($"My name is " + Name);
			Console.WriteLine($"My ears are " + EarSize + "inches tall");

		}
	}
}

