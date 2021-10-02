using PhoneBookDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PhoneBookDemo
{
    [DependsOn(
        typeof(PhoneBookDemoEntityFrameworkCoreTestModule)
        )]
    public class PhoneBookDemoDomainTestModule : AbpModule
    {

    }
}