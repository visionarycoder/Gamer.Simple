using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VisionaryCoder.Components.Accessor.GameDefinition.Interface;
using VisionaryCoder.Framework;
using VisionaryCoder.Resource.DataSource;

namespace VisionaryCoder.Components.Accessor.GameDefinition.Service;

internal class GameDefinitionAccess : Service<GameDefinitionAccess>, IGameDefinitionAccess
{

	private readonly GamerDbContext db;

	public GameDefinitionAccess(GamerDbContext context, ILogger<GameDefinitionAccess> logger)
	: base(logger)
	{
		db = context;
	}

	public async Task<List<Interface.GameDefinition>> GetGameDefinitions()
	{
		throw new NotImplementedException();
	}

	public async Task<Interface.GameDefinition> GetGameDefinition(Guid gameDefinitionId)
	{
		throw new NotImplementedException();
	}

	public async Task<List<Interface.GameDefinition>> FindGameDefinitions(GameDefinitionFilter filter)
	{
		var dbObject = await db.GameDefinitions.SingleOrDefaultAsync(i => i.Id == filter.GameDefinitionId);
		return dbObject.Convert();
	}

}

