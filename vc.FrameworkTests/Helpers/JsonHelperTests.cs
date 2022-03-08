﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace vc.Framework.Helpers.Tests
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

	public class Node
	{

		public Guid Id { get; set; } = Guid.Empty;
		public string Name { get; set; } = "Test Class Name";
		public Node[] ChildNodes { get; set; } = Array.Empty<Node>();

	}

}