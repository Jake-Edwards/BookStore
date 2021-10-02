using PhoneBookDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace PhoneBookDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PhoneBookDemoEntityFrameworkCoreModule),
        typeof(PhoneBookDemoApplicationContractsModule)
        )]
    public class PhoneBookDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
