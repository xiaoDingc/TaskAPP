using System;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Castle.Facilities.Logging;

namespace SimpleTaskSystem.Web
{
    public class MvcApplication : AbpWebApplication<SimpleTaskSystemWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
            );
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Task, TaskDto>();
            });
            base.Application_Start(sender, e);
        }
    }
}
