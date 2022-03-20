using Microsoft.Extensions.Logging;

namespace VisionaryCoder.Framework;

public abstract class Service<T>
{

	protected ILogger<T> logger { get; init; }

	protected Service(ILogger<T> logger)
	{
		this.logger = logger;
	}

}

