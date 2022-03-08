namespace vc.Resource.DataSource.Model;

public class BoardGameDefinition
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string[] GamePieces { get; set; }
	public int MaxNumberOfPlayers { get; set; }
	public int MinNumberOfPlayers { get; set; }
	public string TurnPrompt { get; set; }
}