using System.Reflection;
using System.Text;

namespace vc.Components.Accessor.Player.Service.Helpers
{
	internal static class PlayerEx
	{

		public static Interface.Player Convert(this VisionaryCoder.Resource.DataSource.Model.Player source)
		{
			var target = new Interface.Player
			{
				GamePiece = source.GamePiece,
				Id = source.Id,
				IsMachine = source.IsMachine,
				Name = source.Name
			};
			return target;
		}

		public static VisionaryCoder.Resource.DataSource.Model.Player Convert(this Interface.Player source)
		{
			var target = new VisionaryCoder.Resource.DataSource.Model.Player
			{
				GamePiece = source.GamePiece,
				Id = source.Id,
				IsMachine = source.IsMachine,
				Name = source.Name
			};
			return target;
		}

		public static string LabelValue(this object source, string propertyName)
		{
			var value = source.GetType().GetProperty(propertyName)?.GetValue(source)?.ToString();
			return $"\"{propertyName}\":\"{value}\"";
		}

		public static string ToJson(this object source)
		{

			var output = new StringBuilder("{");
			var propertyNames = source.GetType().GetProperties(BindingFlags.Public).Select(i => i.Name);
			foreach (var propertyName in propertyNames)
			{
				output.Append(source.LabelValue(propertyName));

			}
			output.AppendLine("}");
			return $"{output}";
		}

	}

}
