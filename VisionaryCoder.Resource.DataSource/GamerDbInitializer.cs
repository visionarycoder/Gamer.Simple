using VisionaryCoder.Resource.DataSource.Model;

namespace VisionaryCoder.Resource.DataSource
{
	public static class GamerDbInitializer
	{

		/// <summary>
		/// Load sample data.
		/// </summary>
		/// 
		/// <param name="db"></param>
		public static async Task Initialize(GamerDbContext db)
		{

			if (db.GameDefinitions.Any())
				return;

			var game = new BoardGameDefinition
			{
				Id = Guid.NewGuid(),
				Name = "Tic-Tac-Toe",
				Description = "The Classic three across game.  Also known as 'noughts and crosses' or 'Xs and Os.'",
				GamePieces = new[] { "X", "O" },
				MaxNumberOfPlayers = 2,
				MinNumberOfPlayers = 0,
				TurnPrompt = "Your turn.",
			};

			await db.GameDefinitions.AddAsync(game);
			await db.SaveChangesAsync();

		}

	}

}