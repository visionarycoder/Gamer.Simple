using Microsoft.EntityFrameworkCore;
using VisionaryCoder.Resource.DataSource.Model;

namespace VisionaryCoder.Resource.DataSource
{

	public class GamerDbContext : DbContext
	{

		public string ConnectionString { get; }

		public GamerDbContext(string connectionString)
		{
			ConnectionString = connectionString;
		}

		public DbSet<BoardGameDefinition> GameDefinitions { get; set; }
		public DbSet<GameSession> GameSessions { get; set; }

		public DbSet<GamePiece> GamePieces { get; set; }
		public DbSet<Card> GameCards { get; set; }

		public DbSet<Player> Players { get; set; }

	}

}