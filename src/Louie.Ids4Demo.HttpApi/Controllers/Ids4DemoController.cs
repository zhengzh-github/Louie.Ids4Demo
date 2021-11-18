using Louie.Ids4Demo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Louie.Ids4Demo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Ids4DemoController : AbpController
    {
        protected Ids4DemoController()
        {
            LocalizationResource = typeof(Ids4DemoResource);
        }
    }
}