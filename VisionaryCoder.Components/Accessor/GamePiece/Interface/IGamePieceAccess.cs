namespace VisionaryCoder.Components.Accessor.GamePiece.Interface;

public interface IGamePieceAccess
{
	
	Task<List<GamePiece>> CreateGamePiecesAsync(List<GamePiece> gamePieces);
	Task<List<GamePiece>> FindGamePiecesAsync(Func<GamePiece,bool> filter);
	Task<bool> RemoveGamePieceAsync(Guid gameSessionId);
	Task<bool> RemovesGamePieceAsync(List<Guid> gameSessionId);
	Task<List<GamePiece>> UpdateGamePiecesAsync(List<GamePiece> gamePieces);
	Task<List<GamePiece>> UpdateGamePieceAsync(GamePiece gamePiece);

}