using PhoneBookDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PhoneBookDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class PhoneBookDemoController : AbpController
    {
        protected PhoneBookDemoController()
        {
            LocalizationResource = typeof(PhoneBookDemoResource);
        }
    }
}