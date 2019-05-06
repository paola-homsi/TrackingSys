using log4net;

namespace TrackingSystem.Common.Contracts
{
    public interface ILogService
    {
        ILog Logger();
    }
}
