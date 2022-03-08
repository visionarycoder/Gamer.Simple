namespace vc.Components.Accessor.Game.Interface
{

    internal class GameDefinition
    {

		public Guid Id { get; init; }
		public string Name { get; init; } = string.Empty;
		public string Description { get; init; } = string.Empty;
		public Guid[] GamePieces { get; init; } = Array.Empty<Guid>();
		public string TurnPrompt { get; init; } = string.Empty;
		public int MaxNumberOfPlayers { get; init; }
		public int MinNumberOfPlayers { get; init; }
		public string[] Tags { get; init; } = Array.Empty<string>();

	}

}
