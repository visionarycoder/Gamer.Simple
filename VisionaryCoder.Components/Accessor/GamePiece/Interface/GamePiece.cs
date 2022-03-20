using System.Runtime.Serialization;
using VisionaryCoder.Components.Accessor.GamePiece.Service;

namespace VisionaryCoder.Components.Accessor.GamePiece.Interface;

[DataContract] public class GamePiece
{
	
	[DataMember] public Guid Id { get; set; }
	[DataMember] public Guid GameSessionId { get; set; }
	[DataMember] public Address Address { get; set; }
	[DataMember] public Guid PlayerId { get; set; }

}