using System.Runtime.Serialization;

namespace VisionaryCoder.Components.Accessor.Player.Interface
{

	[DataContract] public class Player
	{
		[DataMember] public Guid Id { get; init; }
		[DataMember] public string Name { get; init; }
		[DataMember] public bool IsMachine { get; init; }
		[DataMember] public List<Guid> GamePieceIds { get; set; }
	}
	
}

