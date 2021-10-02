using System;
using System.Collections.Generic;
using System.Text;
using PhoneBookDemo.Localization;
using Volo.Abp.Application.Services;

namespace PhoneBookDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class PhoneBookDemoAppService : ApplicationService
    {
        protected PhoneBookDemoAppService()
        {
            LocalizationResource = typeof(PhoneBookDemoResource);
        }
    }
}
