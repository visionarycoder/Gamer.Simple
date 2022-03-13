using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vc.Engine.BoardGame.Interface;
using vc.Accessor.Game.Service;
using System.Data;

namespace vc.Engine.BoardGame.Service
{

	internal class BoardGameEngine : IBoardGameEngine
	{

		private readonly IGameAccess gameAccess;

		public BoardGameEngine(IGameAccess gameAccess)
		{
			this.gameAccess = gameAccess;
		}

		public async Task<DataTable> GetBoard(Guid gameSessionId)
		{

			// Board for Tic-Tac-Toe
			var gameSession = await gameAccess.GetGameSession(gameSessionId);
			var players = new List<Player>();
			foreach (var playerId in gameSession.PlayerIds)
			{
				var player = await playerAccess.GetPlayer(playerId);
				players.Add(player);
			}

			var tiles = await tileAccess.FindTiles(gameSessionId);

			var dataTable = new DataTable();
			dataTable.Columns.Add(new DataColumn(" "));
			dataTable.Columns.Add(new DataColumn("A"));
			dataTable.Columns.Add(new DataColumn("B"));
			dataTable.Columns.Add(new DataColumn("C"));

			var dataRow = dataTable.NewRow();
			dataRow[0] = 1;
			dataRow[1] = (tiles[0].PlayerId == Guid.Empty ? " " : players.First(i => i.Id == tiles[0].PlayerId).GamePiece);
			dataRow[2] = (tiles[3].PlayerId == Guid.Empty ? " " : players.First(i => i.Id == tiles[3].PlayerId).GamePiece);
			dataRow[3] = (tiles[6].PlayerId == Guid.Empty ? " " : players.First(i => i.Id == tiles[6].PlayerId).GamePiece);
			dataTable.Rows.Add(dataRow);

			dataRow = dataTable.NewRow();
			dataRow[0] = 2;
			dataRow[1] = (tiles[1].PlayerId == Guid.Empty ? " " : players.First(i => i.Id == tiles[1].PlayerId).GamePiece);
			dataRow[2] = (tiles[4].PlayerId == Guid.Empty ? " " : players.First(i => i.Id == tiles[4].PlayerId).GamePiece);
			dataRow[3] = (tiles[7].PlayerId == Guid.Empty ? " " : players.First(i => i.Id == tiles[7].PlayerId).GamePiece);
			dataTable.Rows.Add(dataRow);

			dataRow = dataTable.NewRow();
			dataRow[0] = 3;
			dataRow[1] = (tiles[2].PlayerId == Guid.Empty ? " " : players.First(i => i.Id == tiles[2].PlayerId).GamePiece);
			dataRow[2] = (tiles[5].PlayerId == Guid.Empty ? " " : players.First(i => i.Id == tiles[5].PlayerId).GamePiece);
			dataRow[3] = (tiles[8].PlayerId == Guid.Empty ? " " : players.First(i => i.Id == tiles[8].PlayerId).GamePiece);
			dataTable.Rows.Add(dataRow);

			return dataTable;

		}

	}

}
