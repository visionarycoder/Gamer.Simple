using Newtonsoft.Json;

namespace VisionaryCoder.Framework.Helpers
{
	public static class JsonHelper
	{

		public static string ToJson(this object source)
		{
			return JsonConvert.SerializeObject(source);
		}

	}

}
