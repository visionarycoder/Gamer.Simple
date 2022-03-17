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

		public DbSet<BoardGameDefinition> BoardGameDefinitions { get; set; }
		public DbSet<CardGameDefinition> CardGameDefinitions { get; set; }
		public DbSet<GameSession> GameSessions { get; set; }
		public DbSet<GamePiece> GamePieces { get; set; }
		public DbSet<Card> Cards { get; set; }
		public DbSet<Player> Players { get; set; }
		public DbSet<Board> Boards { get; set; }

	}

}