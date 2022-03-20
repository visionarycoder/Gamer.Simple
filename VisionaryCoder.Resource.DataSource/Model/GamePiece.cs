namespace VisionaryCoder.Resource.DataSource.Model;

public class GamePiece
{
	
	public Guid Id { get; set; }
	public Guid GameSessionId { get; set; }
	public Guid PlayerId { get; set; }

	public string Label { get; set; }
	
	public byte[] Image { get; set; }
	public string ImagePath { get; set; }

	public int X { get; set; }
	public int Y { get; set; }

}