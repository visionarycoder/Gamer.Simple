using VisionaryCoder.Framework;

namespace VisionaryCoder.Components.Accessor.Player.Interface
{

	public interface IPlayerAccess: IService
	{

		Task<Player> GetPlayer(Guid playerId);
		Task<List<Player>> FindPlayers(FindPlayersFilter filter);
		Task<Player> CreatePlayer(Player player);
		Task<List<Player>> CreatePlayers(List<Player> players);
		Task<bool> RemovePlayer(Player player);
		Task<bool> RemovePlayers(List<Player> players);

	}

}