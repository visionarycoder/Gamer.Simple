namespace VisionaryCoder.Resource.DataSource.Model
{
	public class CardGameDefinition
	{

		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int MaxNumberOfPlayers { get; set; }
		public int MinNumberOfPlayers { get; set; }
		public string TurnPrompt { get; set; }

		public virtual Card[] Cards { get; set; }

	}

}