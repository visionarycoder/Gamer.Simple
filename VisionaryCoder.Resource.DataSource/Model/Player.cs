namespace VisionaryCoder.Resource.DataSource.Model;

public class Player
{

	public Guid Id { get; set; }
	public string Name { get; set; } = "Undefined";
	public bool IsMachine { get; set; }
	public Guid GamePieceId { get; set; }
	public virtual GamePiece GamePiece { get; set; }

}