using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
    public class ArtistController : Controller
    {
        [HttpGet("/artists")]
        public ActionResult Index()
        {
          return View();
        }


    }
}
