using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vc.Engine.BoardGame.Interface
{
	internal interface IBoardGameEngine
	{
		Task<DataTable> GetBoard(Guid gameSessionId);
	}
}
