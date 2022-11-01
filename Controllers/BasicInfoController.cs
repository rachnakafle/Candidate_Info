using Microsoft.AspNetCore.Mvc;

namespace Candidate_Info.Controllers
{
    public class BasicInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
