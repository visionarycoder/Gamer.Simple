namespace VisionaryCoder.Components.Accessor.Player.Interface
{
	public class BoardGamePlayer
	{

		public Guid Id { get; init; }
		public string Name { get; init; }
		public bool IsMachine { get; init; }
		public Guid GamePieceId { get; init; }

	}


}

