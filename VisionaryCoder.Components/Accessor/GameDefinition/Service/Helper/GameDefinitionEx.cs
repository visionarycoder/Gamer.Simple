using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionaryCoder.Components.Accessor.GameDefinition.Service.Helper
{
	internal static class GameDefinitionEx
	{

		public static Resource.DataSource.Model.GameDefinition Convert(this Interface.GameDefinition source)
		{
			var target = new Resource.DataSource.Model.GameDefinition
			{
				Id = source.Id,
				Name = source.Name,
				Description = source.Description,
				MaxNumberOfPlayers = source.MaxNumberOfPlayers,
				MinNumberOfPlayers = source.MinNumberOfPlayers,
				TurnPrompt = source.TurnPrompt,
				GamePieceIds = source.GamePieceIds,
			}
		}
	}
}
