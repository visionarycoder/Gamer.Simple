namespace vc.Components.Accessor.Game.Interface
{

	public class GameSession
	{

		public Guid Id { get; init; }
		public Guid[] PlayerIds { get; init; }
		public Guid GameDefinitionId { get; init; }
		public Guid CurrentPlayerId { get; set; }

	}

}