using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusSignalRClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
