using Microsoft.EntityFrameworkCore;

using System.Data;
using System.Diagnostics;

using vc.Components.Accessor.Player.Interface;
using vc.Components.Accessor.Player.Service.Helpers;
using VisionaryCoder.Framework.Responses;
using VisionaryCoder.Resource.DataSource;

namespace vc.Components.Accessor.Player.Service;

public class PlayerAccess : IPlayerAccess
{

	private readonly GamerDbContext db;

	public PlayerAccess(GamerDbContext db)
	{
		this.db = db;
	}

	public async Task<Interface.Player> GetPlayer(Guid playerId)
	{

		var player = await db.Players.SingleOrDefaultAsync(i => i.Id == playerId);
		return player?.Convert();

	}

	public async Task<DeleteResponse> DeletePlayer(Guid playerId)
	{

		var response = new DeleteResponse
		{
			EntityFound = true
		};

		var entity = await db.Players.SingleOrDefaultAsync(i => i.Id == playerId);
		if (entity == null)
		{
			response.EntityFound = false;
		}
		else
		{
			db.Players.Remove(entity);
			var count = await db.SaveChangesAsync();
			response.Success = count > 0;
		}
		return response;

	}

	public async Task<Interface.Player> AddPlayer(Interface.Player player)
	{

		var entity = await db.Players.SingleOrDefaultAsync(i => i.Id == player.Id);
		if (entity != null)
			throw new DataException("Entity already exists");

		Trace.Write($"Before: {player.ToJson()}");
		entity = new VisionaryCoder.Resource.DataSource.Model.Player
		{
			GamePiece = player.GamePiece,
			Id = player.Id,
			IsMachine = player.IsMachine,
			Name = player.Name,
		};
		var entityEntry = await db.Players.AddAsync(entity);
		player = entityEntry.Entity.Convert();
		Trace.Write($"After: {player.ToJson()}");
		return player;

	}

	public async Task<Interface.Player[]> CreatePlayers(Interface.Player[] players)
	{

		var list = new List<Interface.Player>();
		foreach (var player in players)
		{
			list.Add(await AddPlayer(player));
		}
		return list.ToArray();

	}

}