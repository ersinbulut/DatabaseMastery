using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportMongoDb.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public IActionResult Index()
        {
            return View();
        }
    }
}
