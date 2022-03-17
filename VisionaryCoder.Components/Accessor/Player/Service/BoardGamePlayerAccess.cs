using System.Data;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using VisionaryCoder.Components.Accessor.Player.Interface;
using VisionaryCoder.Components.Accessor.Player.Service.Helpers;
using VisionaryCoder.Framework.Responses;
using VisionaryCoder.Resource.DataSource;

namespace VisionaryCoder.Components.Accessor.Player.Service;

public class BoardGamePlayerAccess : IBoardGamePlayerAccess
{

	private readonly GamerDbContext db;

	public BoardGamePlayerAccess(GamerDbContext db)
	{
		this.db = db;
	}

	public async Task<Interface.BoardGamePlayer> GetPlayer(Guid playerId)
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

	public async Task<Interface.BoardGamePlayer> AddPlayer(Interface.BoardGamePlayer boardGamePlayer)
	{

		var entity = await db.Players.SingleOrDefaultAsync(i => i.Id == boardGamePlayer.Id);
		if (entity != null)
			throw new DataException("Entity already exists");

		Trace.Write($"Before: {boardGamePlayer.ToJson()}");
		entity = new VisionaryCoder.Resource.DataSource.Model.Player
		{
			GamePiece = boardGamePlayer.GamePiece,
			Id = boardGamePlayer.Id,
			IsMachine = boardGamePlayer.IsMachine,
			Name = boardGamePlayer.Name,
		};
		var entityEntry = await db.Players.AddAsync(entity);
		boardGamePlayer = entityEntry.Entity.Convert();
		Trace.Write($"After: {boardGamePlayer.ToJson()}");
		return boardGamePlayer;

	}

	public async Task<Interface.BoardGamePlayer[]> CreatePlayers(Interface.BoardGamePlayer[] players)
	{

		var list = new List<Interface.BoardGamePlayer>();
		foreach (var player in players)
		{
			list.Add(await AddPlayer(player));
		}
		return list.ToArray();

	}

}