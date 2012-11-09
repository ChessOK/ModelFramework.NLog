using Autofac;

using NLog;

namespace ModelFramework.NLog
{
    public class NLogModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(x => new NLogLogger(LogManager.GetLogger("Logger")));
        }
    }
}
