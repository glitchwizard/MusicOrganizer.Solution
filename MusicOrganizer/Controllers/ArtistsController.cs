using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
    public class ArtistController : Controller
    {
        [HttpGet("/artists")]
        public ActionResult Index()
        {
          List<Artist> allArtists = Artist.GetAll();
          ViewResult viewResult = View("Index", allArtists);
          return viewResult;
        }

        [HttpPost("/artists")]
        public ActionResult Create(string artistName)
        {
          //Artist newArtist = new Artist(artistName);
          return RedirectToAction("Index");
        }
    }
}
