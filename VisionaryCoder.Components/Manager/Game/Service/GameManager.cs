using System.ComponentModel.DataAnnotations;
using System.Data;
using VisionaryCoder.Components.Manager.Game.Interface;

namespace VisionaryCoder.Components.Manager.Game.Service
{
    internal class GameManager : IGameManager
    {
	    public async Task<GameDefinition[]> GetGames()
	    {
		    throw new NotImplementedException();
	    }

	    public async Task AutoPlayTurn(Guid gameSessionId)
	    {
		    throw new NotImplementedException();
	    }

	    public async Task ApplyTurn(Guid gameSessionId, Guid playerId, string address)
	    {
		    throw new NotImplementedException();
	    }

	    public async Task<ValidationResult> ConfirmUsableAddress(Guid gameSessionId, string address)
	    {
		    throw new NotImplementedException();
	    }

	    public async Task<bool> IsGamePlayable(Guid gameSessionId)
	    {
		    throw new NotImplementedException();
	    }

	    public async Task<Guid> StartGame(Guid gameDefinitionId, int playerCount)
	    {
		    throw new NotImplementedException();
	    }

	    public async Task<DataTable> GetBoard(Guid gameSessionId)
	    {
		    throw new NotImplementedException();
	    }

	    public async Task<string> GetTurnPrompt(Guid gameSessionId)
	    {
		    throw new NotImplementedException();
	    }

	    public async Task<Player> GetCurrentPlayer(Guid gameSessionId)
	    {
		    throw new NotImplementedException();
	    }

	    public async Task<Player> FindWinner(Guid gameSessionId)
	    {
		    throw new NotImplementedException();
	    }
    }
}
