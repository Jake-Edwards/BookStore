using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PhoneBookDemo.Data;
using Volo.Abp.DependencyInjection;

namespace PhoneBookDemo.EntityFrameworkCore
{
    public class EntityFrameworkCorePhoneBookDemoDbSchemaMigrator
        : IPhoneBookDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorePhoneBookDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the PhoneBookDemoDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<PhoneBookDemoDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
