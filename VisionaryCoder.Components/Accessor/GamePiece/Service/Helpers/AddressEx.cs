using VisionaryCoder.Components.Accessor.GamePiece.Interface;

namespace VisionaryCoder.Components.Accessor.GamePiece.Service.Helpers;

internal static class AddressEx
{
	public static Resource.DataSource.Model.Address Convert(this Interface.Address source)
	{
		var target = new Address()
		{

		};
		return target;
	}

	public static Interface.Address Convert(this Resource.DataSource.Model.Address source)
	{
		var target = new Interface.Address
		{

		};
		return target;
	}
}