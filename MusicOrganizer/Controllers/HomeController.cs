using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index() { return View(); }

    }
}
