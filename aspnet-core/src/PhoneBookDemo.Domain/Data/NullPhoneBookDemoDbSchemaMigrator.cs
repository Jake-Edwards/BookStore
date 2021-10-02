using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PhoneBookDemo.Data
{
    /* This is used if database provider does't define
     * IPhoneBookDemoDbSchemaMigrator implementation.
     */
    public class NullPhoneBookDemoDbSchemaMigrator : IPhoneBookDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}