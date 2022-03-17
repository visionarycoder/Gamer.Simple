namespace VisionaryCoder.Resource.DataSource.Model;

public class BoardGameDefinition
{
	
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public GamePiece[] GamePieces { get; set; }
	public int MaxNumberOfPlayers { get; set; }
	public int MinNumberOfPlayers { get; set; }
	public int BoardRows { get; set; }
	public int BoardColumns { get; set; }
	public string TurnPrompt { get; set; }

}