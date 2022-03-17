using VisionaryCoder.Framework.Responses;

namespace VisionaryCoder.Components.Accessor.Player.Interface
{

	public interface IBoardGamePlayerAccess
	{

		Task<BoardGamePlayer> GetPlayer(Guid playerId);
		Task<BoardGamePlayer> AddPlayer(BoardGamePlayer boardGamePlayer);
		Task<DeleteResponse> DeletePlayer(Guid playerId);

	}

}