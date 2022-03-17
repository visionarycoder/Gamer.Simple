using Microsoft.Extensions.Logging;

namespace VisionaryCoder.Framework;

public abstract class Service<T>
{

	protected ILogger logger { get; init; }

	protected Service(ILogger logger)
	{
		this.logger = logger;
	}

}

