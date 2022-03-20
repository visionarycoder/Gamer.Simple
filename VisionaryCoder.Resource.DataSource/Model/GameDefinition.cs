namespace VisionaryCoder.Resource.DataSource.Model;

public class GameDefinition
{
	
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public List<Guid> GamePieceIds { get; set; }
	public int MaxNumberOfPlayers { get; set; }
	public int MinNumberOfPlayers { get; set; }
	public string TurnPrompt { get; set; }
	public virtual ICollection<GamePiece> GamePieces { get; set; }

}