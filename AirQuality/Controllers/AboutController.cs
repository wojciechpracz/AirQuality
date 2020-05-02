using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace AirQuality.Controllers
{
    public class AboutController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

    }
}
