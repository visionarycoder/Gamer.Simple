using System.ComponentModel.DataAnnotations;
using VisionaryCoder.Components.Engine.InputValidating.Interface;

namespace VisionaryCoder.Components.Engine.InputValidating.Service
{

	internal class InputValidatingEngine : IInputValidatingEngine
	{

		public static readonly string NotEmptyInputErrorMessage = "Empty input";
		public static readonly string InputInCollectionErrorMessage = "Unable to match input.";
		
		public ValidationResult ValidateNotEmptyInput(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
				return new ValidationResult(NotEmptyInputErrorMessage);
			return ValidationResult.Success;
		}

		public ValidationResult ValidateInputInCollection(string input, List<string> collection, bool caseSensitive = false)
		{
			if (caseSensitive)
			{
				input = input.ToLowerInvariant();
				collection = collection.Select(i => i.ToLowerInvariant()).ToList();
			}

			return collection.Contains(input) 
				? ValidationResult.Success 
				: new ValidationResult(InputInCollectionErrorMessage);

		}

	}

}