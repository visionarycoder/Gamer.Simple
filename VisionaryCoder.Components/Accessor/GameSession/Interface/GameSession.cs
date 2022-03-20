using System.Runtime.Serialization;

namespace VisionaryCoder.Components.Accessor.GameSession.Interface
{

	[DataContract] public class GameSession
	{

		[DataMember] public Guid Id { get; init; }
		[DataMember] public List<Guid> PlayerIds { get; init; }
		[DataMember] public Guid GameDefinitionId { get; init; }
		[DataMember] public Guid CurrentPlayerId { get; set; }

	}

}