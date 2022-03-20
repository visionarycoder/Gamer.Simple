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

			await InitializeGameDefinition(db);
			await InitializeCards(db);

		}

		private static async Task InitializeGameDefinition(GamerDbContext db)
		{
			if (db.GameDefinitions.Any())
				return;

			var gameDefinition = new GameDefinition
			{
				Id = Guid.NewGuid(),
				Name = "Tic-Tac-Toe",
				Description = "The Classic three across game.  Also known as 'noughts and crosses' or 'Xs and Os.'",
				GamePieces = new[] { new GamePiece{ Id = Guid.NewGuid(), Label = "X" }, new GamePiece { Id = Guid.NewGuid(), Label = "O" } },
				MaxNumberOfPlayers = 2,
				MinNumberOfPlayers = 0,
				TurnPrompt = "Your turn.",
			};
			await db.GameDefinitions.AddAsync(gameDefinition);
			await db.SaveChangesAsync();
		}

		private static async Task InitializeCards(GamerDbContext db)
		{
			
			foreach (var suit in new[] {"Club", "Spade", "Heart", "Diamond"})
			{
				foreach (var values in new[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"})
				{
					var card = new Card 					
					{
						Name = values,
						Value = $"{suit}|{values}"
					};
					await db.Cards.AddAsync(card);
				}
			}
			await db.SaveChangesAsync();

		}

	}

}