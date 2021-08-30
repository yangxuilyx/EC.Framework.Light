using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace EC.Framework.Host.Controllers
{
    public class HomeController : AbpController
    {
        // GET
        public IActionResult Index()
        {
            return Redirect("~/swagger");
        }
    }
}