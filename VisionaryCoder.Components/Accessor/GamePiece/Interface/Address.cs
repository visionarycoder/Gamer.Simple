using System.Runtime.Serialization;

namespace VisionaryCoder.Components.Accessor.GamePiece.Interface;

[DataContract] public class Address
{
	[DataMember] public Guid Id { get; set; }
	[DataMember] public int X { get; set; }
	[DataMember] public int Y { get; set; }
}