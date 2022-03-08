using Newtonsoft.Json;

namespace vc.Framework.Helpers
{
	public static class JsonHelper
	{

		public static string ToJson(object source)
		{
			return JsonConvert.SerializeObject(source);
		}

	}

}
