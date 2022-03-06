using Microsoft.Extensions.Logging;

namespace vc.Framework
{

    public abstract class ServiceBase<T>
    {

        protected ILogger logger { get; init; }

        public ServiceBase()
        : this(new LoggerFactory())
        {

        }

        public ServiceBase(ILoggerFactory factory)
        {
            logger = factory.CreateLogger(typeof(T));
        }

    }

}
