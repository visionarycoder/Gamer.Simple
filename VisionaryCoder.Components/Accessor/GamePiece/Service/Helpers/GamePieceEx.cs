using System.Runtime.CompilerServices;

namespace VisionaryCoder.Components.Accessor.GamePiece.Service.Helpers
{
	internal static class GamePieceEx
	{
		public static Resource.DataSource.Model.GamePiece Convert(this Interface.GamePiece source)
		{
			var target = new Resource.DataSource.Model.GamePiece
			{
				Id = source.Id,
				Address = source.Address.Convert(),
				GameSessionId = source.GameSessionId,
				PlayerId = source.PlayerId
			};
			return target;
		}

		public static Interface.GamePiece Convert(this Resource.DataSource.Model.GamePiece source)
		{
			var target = new Interface.GamePiece
			{
				Id = source.Id,
				Address = source.Address.Convert(),
				GameSessionId = source.GameSessionId,
				PlayerId = source.PlayerId
			};
			return target;
		}
	}
}
