using System;
using System.Collections.Generic;
using System.Text;
using Louie.Ids4Demo.Localization;
using Volo.Abp.Application.Services;

namespace Louie.Ids4Demo
{
    /* Inherit your application services from this class.
     */
    public abstract class Ids4DemoAppService : ApplicationService
    {
        protected Ids4DemoAppService()
        {
            LocalizationResource = typeof(Ids4DemoResource);
        }
    }
}
