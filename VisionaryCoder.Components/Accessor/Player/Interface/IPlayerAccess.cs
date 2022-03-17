using VisionaryCoder.Framework.Responses;

namespace vc.Components.Accessor.Player.Interface
{

	public interface IPlayerAccess
	{

		Task<Player> GetPlayer(Guid playerId);
		Task<Player> AddPlayer(Player player);
		Task<DeleteResponse> DeletePlayer(Guid playerId);

	}

}