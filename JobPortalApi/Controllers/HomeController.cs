using JobPortalApi.CustomFilters;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalApi.Controllers
{
    public class HomeController : Controller
    {
        [Custom]
        public IActionResult Index()
        {
            return View();
        }
    }
}
