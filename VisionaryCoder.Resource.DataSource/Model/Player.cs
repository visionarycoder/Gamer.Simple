namespace VisionaryCoder.Resource.DataSource.Model;

public class Player
{

	public Guid Id { get; set; } = Guid.NewGuid();
	public string Name { get; set; } = "Undefined";
	public bool IsMachine { get; set; }
	public List<Guid> GamePieceIds { get; set; } = new List<Guid>();

	public virtual ICollection<GamePiece> GamePieces { get; set; } = new List<GamePiece>();

}