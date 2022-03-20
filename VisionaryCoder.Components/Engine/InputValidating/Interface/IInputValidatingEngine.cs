using System.ComponentModel.DataAnnotations;

namespace VisionaryCoder.Components.Engine.InputValidating.Interface
{
	
	public interface IInputValidatingEngine
	{
		ValidationResult ValidateNotEmptyInput(string input);
		ValidationResult ValidateInputInCollection(string input, List<string> collection, bool caseSensitive = false);
	}

}
