using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisionaryCoder.Framework.Helpers;

namespace VisionaryCoder.Framework.Tests.Helpers
{

	[TestClass]
	public class JsonHelperTests
	{

		[TestMethod]
		public void ToJsonTest()
		{

			var actual = new Node();
			var expected = JsonHelper.ToJson(actual);

			Assert.IsFalse(string.IsNullOrWhiteSpace(expected));

		}
	}
}