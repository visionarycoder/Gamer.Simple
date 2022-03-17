using Microsoft.Extensions.Logging;

namespace VisionaryCoder.Framework;

public abstract class ServiceBase<T>
{

	protected ILogger logger { get; init; }

	protected ServiceBase()
	: this(new LoggerFactory())
	{

	}

	protected ServiceBase(ILogger logger)
	{
		this.logger = logger;
	}

	protected ServiceBase(ILoggerFactory factory)
	{
		logger = factory.CreateLogger(typeof(T));
	}

}

