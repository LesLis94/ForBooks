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
			Console.WriteLine($"My ears are " + EarSize + " inches tall");

		}

		public void SpeakTo(Elephant whoToTalkTo, string messege)
		{
			whoToTalkTo.HearMessege(messege, this);
		}

		public void HearMessege(string messege, Elephant whoSaidIt)
		{
			Console.WriteLine(Name + " heard a messege");
			Console.WriteLine(whoSaidIt.Name + " said this: " + messege);
		}
	}
}

