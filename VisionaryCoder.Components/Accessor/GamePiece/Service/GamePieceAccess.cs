using System.Diagnostics.Contracts;
using Microsoft.Extensions.Logging;
using VisionaryCoder.Components.Accessor.GamePiece.Interface;
using VisionaryCoder.Framework;
using VisionaryCoder.Resource.DataSource;

namespace VisionaryCoder.Components.Accessor.GamePiece.Service
{
	internal class GamePieceAccess : Service<GamePieceAccess>, IGamePieceAccess
	{

		private GamerDbContext db;

		public GamePieceAccess(GamerDbContext dbContext, ILogger logger)
			: base(logger)
		{
			db = dbContext;
		}

		public async Task<List<Interface.GamePiece>> CreateGamePiecesAsync(List<Interface.GamePiece> gamePieces)
		{
			var dbObject = gamePieces.Select(i => i.Convert());
			await db.GamePieces.AddRangeAsync(dbObject);
			throw new NotImplementedException();
		}

		public async Task<List<Interface.GamePiece>> FindGamePiecesAsync(Func<Interface.GamePiece, bool> filter)
		{
			Contract.Assert(filter != null);
			throw new NotImplementedException();
		}

		public async Task<bool> RemoveGamePieceAsync(Guid gameSessionId)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> RemovesGamePieceAsync(List<Guid> gameSessionId)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Interface.GamePiece>> UpdateGamePiecesAsync(List<Interface.GamePiece> gamePieces)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Interface.GamePiece>> UpdateGamePieceAsync(Interface.GamePiece gamePiece)
		{
			throw new NotImplementedException();
		}

	}

}
