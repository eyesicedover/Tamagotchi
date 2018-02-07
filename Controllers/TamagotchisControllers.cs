using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tamagotchis.Models;

namespace Tamagotchis.Controllers
{
    public class TamagotchisController : Controller
    {
        [HttpGet("/tamagotchis")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/tamagotchis/new")]
        public ActionResult Create()
        {
            Tama newTama = new Tama(Request.Form["tamaName"])
            return View("Game", newTama);
        }
    }
}
