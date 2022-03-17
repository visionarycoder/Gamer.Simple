using System;

namespace VisionaryCoder.Framework.Tests.Helpers;

public class Node
{

	public Guid Id { get; set; } = Guid.Empty;
	public string Name { get; set; } = "Test Class Name";
	public Node[] ChildNodes { get; set; } = Array.Empty<Node>();

}