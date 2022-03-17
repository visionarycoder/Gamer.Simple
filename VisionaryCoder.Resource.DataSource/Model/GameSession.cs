namespace VisionaryCoder.Resource.DataSource.Model
{

	public class GameSession
	{

		public Guid Id { get; set; }
		public Guid GameId { get; set; }
		public List<Guid> PlayerIds { get; set; } = new List<Guid>();
		public virtual List<Player> Players { get; set; } = new List<Player>();

	}

}