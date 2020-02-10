namespace DecisionMaking
{
	public class Problem
	{
		public uint Id;
		public string Name;
		public string desc;
		public Option[] Options;
	}

	public class Option
	{
		public string Name;
		public uint Chance;
		public int Earning;
	}


	public class Decide
	{
		public Option Make(Problem p)
		{

		}
	}
}