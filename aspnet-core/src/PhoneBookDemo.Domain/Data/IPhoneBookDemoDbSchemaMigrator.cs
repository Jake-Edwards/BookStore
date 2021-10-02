using System.Threading.Tasks;

namespace PhoneBookDemo.Data
{
    public interface IPhoneBookDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
