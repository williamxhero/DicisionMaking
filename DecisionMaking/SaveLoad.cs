using System.IO;
using Newtonsoft.Json;

namespace DecisionMaking
{


	public class DataBase
	{
		public Problem Load(uint id)
		{
			var JS = new JsonSerializer();
			using (var SR = new StreamReader($"Options/{id}.json"))
			using (var Rdr = new JsonTextReader(SR))
			{
				return JS.Deserialize<Problem>(Rdr);
			}
		}

		public void Save(Problem p)
		{
			Directory.CreateDirectory("Options");

			var JS = new JsonSerializer();
			using (var SW = new StreamWriter($"Options/{p.Id}.json"))
			using (var Wtr = new JsonTextWriter(SW))
			{
				JS.Serialize(Wtr, p);
			}
		}

	}


}