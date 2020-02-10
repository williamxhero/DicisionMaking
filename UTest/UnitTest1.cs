using NUnit.Framework;
using DecisionMaking;

namespace UTest
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void TestSave()
		{
			var Db = new DataBase();
			var P = new Problem { Name = "Test Problem", Id = 999 };
			P.Options = new Option[] { new Option { Name = "Opt1", Chance = 50, Earning = 10000 }, new Option { Name = "Opt2", Chance = 30, Earning = 20000 } };
			//Db.Save(P);
		}

		[Test]
		public void TestLoad() {
			var Db = new DataBase();

			var Pld = Db.Load(999);

			Assert.AreEqual(Pld.Id, 999);
			Assert.AreEqual(Pld.Name, "Test Problem");
			Assert.AreEqual(Pld.Options.Length, 2);

			var Op = Pld.Options[0];
			Assert.AreEqual(Op.Name, "Opt1");
			Assert.AreEqual(Op.Chance, 50);
			Assert.AreEqual(Op.Earning, 10000);
		}
	}
}