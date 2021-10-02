using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace PhoneBookDemo
{
    [Dependency(ReplaceServices = true)]
    public class PhoneBookDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "PhoneBookDemo";
    }
}
