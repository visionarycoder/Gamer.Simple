using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using VisionaryCoder.Components.Accessor.Player.Interface;
using VisionaryCoder.Framework;
using VisionaryCoder.Resource.DataSource;
using VisionaryCoder.Resource.DataSource.Model;

namespace VisionaryCoder.Components.Accessor.Board.Service
{

	public interface IBoardAccess
	{
		Task<Board> GetBoard(Guid id);
	}

	internal class BoardAccess : Service<BoardAccess>, IBoardAccess
	{

		private readonly GamerDbContext db;

		public BoardAccess(GamerDbContext dbContext, ILogger logger)
			: base(logger)
		{
			db = dbContext;
		}

		public async Task<Board> GetBoard(Guid gameSessionId)
		{
			var board = db.Boards.Single
		}
	}

	[DataContract]
	public class Board
	{
	
		[DataMember] public Guid Id { get; set; }
		[DataMember] public Address Address { get; set; }

	}

}
