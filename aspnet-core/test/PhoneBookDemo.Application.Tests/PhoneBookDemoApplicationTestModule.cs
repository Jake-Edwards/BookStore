using Volo.Abp.Modularity;

namespace PhoneBookDemo
{
    [DependsOn(
        typeof(PhoneBookDemoApplicationModule),
        typeof(PhoneBookDemoDomainTestModule)
        )]
    public class PhoneBookDemoApplicationTestModule : AbpModule
    {

    }
}