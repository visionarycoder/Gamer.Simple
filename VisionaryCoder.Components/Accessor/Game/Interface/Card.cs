namespace VisionaryCoder.Components.Accessor.Game.Interface
{

	public class Card
	{
	
		public Guid Id { get; set; } = Guid.Empty;
		public string Value { get; set; }
		public string Description { get; set; }
		public byte[] Image { get; set; }
		public string ImagePath { get; set; }

	}

}