namespace VisionaryCoder.Components.Accessor.GameDefinition.Interface;

public interface IGameDefinitionAccess
{

	Task<List<GameDefinition>> GetGameDefinitions();
	Task<GameDefinition> GetGameDefinition(Guid gameDefinitionId);
	Task<List<GameDefinition>> FindGameDefinitions(GameDefinitionFilter filter);

}