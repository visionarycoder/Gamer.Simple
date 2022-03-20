using System.Runtime.Serialization;

namespace VisionaryCoder.Components.Accessor.GameDefinition.Interface
{

	[DataContract] public class GameDefinition 
	{

		[DataMember] public Guid Id { get; init; }
		[DataMember] public string Name { get; init; } = string.Empty;
		[DataMember] public string Description { get; init; } = string.Empty;
		[DataMember] public List<Guid> GamePieceIds { get; set; } = new List<Guid>();
		[DataMember] public string TurnPrompt { get; init; } = string.Empty;
		[DataMember] public int MaxNumberOfPlayers { get; init; }
		[DataMember] public int MinNumberOfPlayers { get; init; }

	}
}